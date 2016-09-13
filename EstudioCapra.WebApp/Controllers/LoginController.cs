using EstudioCapra.Backend;
using EstudioCapra.Model.Login;
using EstudioCapra.WebApp.Controllers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using System;
using System.Linq;

namespace EstudioCapra.Controllers
{
    public class LoginController : BaseController
    {
        public LoginController(IUnitOfWork unitOfWork)
        {
            base._UnitOfWork = unitOfWork;
        }

        public ActionResult Index()
        {
            return this.View();
        }

        public ActionResult Authenticate(LoginModel account)
        {
            if ((from x in _UnitOfWork.UsuarioRepository.GetAll()
                 select x).ToList().Exists(x => x.Email == account.Email && x.Contraseña == account.Contraseña))
            {
                base.HttpContext.Session.SetString("USER", account.Email);

                return this.RedirectToAction("Authorize", new RouteValueDictionary(new
                {
                    action = "Authorize"
                }));
            }
            else
            {
                return this.RedirectToAction("Index");
            }
        }

        public ActionResult Authorize()
        {
            var user = base.HttpContext.Session.GetString("USER").ToString();

            var model = (from x in _UnitOfWork.UsuarioRolRepository.GetAll()
                         join u in _UnitOfWork.UsuarioRepository.GetAll() on x.UserId equals u.UserId
                         join r in _UnitOfWork.RolRepository.GetAll() on x.RolId equals r.RolId
                         where u.Email == user
                         select new MenuModel()
                         {
                             Nombre = u.Nombre,
                             Apellido = u.Apellido,
                             DefaultController = r.DefaultController,
                             DefaultAction = r.DefaultAction,
                             MenuItems = (from i in r.ItemMenu
                                          select new MenuItemModel()
                                          {
                                              MenuId = i.ItemMenuId,
                                              MenuName = i.Name,
                                              DisplayName = i.Name,
                                              Controller = i.Controlador,
                                              Action = i.Accion,
                                              ParentId = i.ItemMenuPadreId
                                          }).ToList()
                         }).ToList().FirstOrDefault();

            return View("_Menu", model);
        }

        public ActionResult LogOut()
        {
            base.HttpContext.Session.SetString("USER", string.Empty);

            var result = this.RedirectToAction("Index", new RouteValueDictionary(new
            {
                controller = "Login",
                action = "Index"
            }));

            return result;
        }
    }
}
