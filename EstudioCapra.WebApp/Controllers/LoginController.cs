using EstudioCapra.Backend;
using EstudioCapra.Model.Login;
using EstudioCapra.WebApp.Controllers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace EstudioCapra.Controllers
{
    public class LoginController : BaseController
    {
        public LoginController(UnitOfWork unitOfWork)
        {
            base._UnitOfWork = unitOfWork;
        }

        public ActionResult Index()
        {
            return this.View();
        }

        public ActionResult Authenticate(LoginModel account)
        {
            base.HttpContext.Session.SetString("USER", account.user);
            return this.View();
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
