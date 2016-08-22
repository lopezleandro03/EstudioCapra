using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using System;

namespace EstudioCapra.WebApp.Controllers
{
    public class HomeController : BaseController
    {
        public IActionResult Index()
        {

            bool flag = string.IsNullOrEmpty(base.HttpContext.Session.GetString("USER"));
            IActionResult result;
            if (!flag) //Just for testing
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
