using EstudioCapra.Backend;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using System;
using System.Linq;

namespace EstudioCapra.WebApp.Controllers
{
    public class HomeController : BaseController
    {
        public HomeController(IUnitOfWork work)
        {
            _UnitOfWork = work;
        }

        public IActionResult Index()
        {

            bool flag = string.IsNullOrEmpty(base.HttpContext.Session.GetString("USER"));
            IActionResult result;

            if (flag) //Just for testing
            {
                result = this.RedirectToAction("Index", new RouteValueDictionary(new
                {
                    controller = "Login",
                    action = "Index"
                }));
            }
            else
            {
                result = this.View();
            }
            return result;
        }

        public IActionResult Menu()
        {
            return View("_Menu");
        }

        public IActionResult Dashboard()
        {

            var contratosNuevos = from x in _UnitOfWork.ContratoRepository.GetAll() where x.FechaInicio > DateTime.Now.AddMonths(-1) select x;
            ViewBag.ContratosNuevos = contratosNuevos.Count();

            var tareasActivas = from x in _UnitOfWork.TareaRespository.GetAll() where x.FechaInicio < DateTime.Now && x.FechaFin > DateTime.Now select x;
            ViewBag.TareasActivas = tareasActivas.Count();

            return this.View();
        }

        public IActionResult About()
        {
            base.ViewData["Message"] = "Your application description page.";
            return this.View();
        }

        public IActionResult Contact()
        {
            base.ViewData["Message"] = "Your contact page.";
            return this.View();
        }

        public IActionResult Error()
        {
            return this.View();
        }
    }
}
