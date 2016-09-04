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
                
                return this.RedirectToAction("Index", new RouteValueDictionary(new
                {
                    controller = "Home",
                    action = "Index"
                }));
            }
            else
            {
                return this.RedirectToAction("Index");
            }
        }

        public PartialViewResult Create()
        {
            return this.PartialView();
        }

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            ActionResult result;
            try
            {
                result = this.RedirectToAction("Index");

                return this.RedirectToAction("Index", new RouteValueDictionary(new
                {
                    controller = "Home",
                    action = "Index"
                }));
            }
            catch
            {
                result = this.View();
            }
            return result;
        }

        public ActionResult Edit(int id)
        {
            return this.View();
        }

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            ActionResult result;
            try
            {
                result = this.RedirectToAction("Index");
            }
            catch
            {
                result = this.View();
            }
            return result;
        }

        public ActionResult Delete(int id)
        {
            return this.View();
        }

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            ActionResult result;
            try
            {
                result = this.RedirectToAction("Index");
            }
            catch
            {
                result = this.View();
            }
            return result;
        }
    }
}
