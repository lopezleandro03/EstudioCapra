using EstudioCapra.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EstudioCapra.Controllers
{
    public class ServiceController : Controller
    {
        //
        // GET: /Service/
        public ActionResult Index()
        {
            ServiceModel s1 = new ServiceModel() 
            {
                Id = 1,
                Name = "Cumpleaños Maria",
                Description = "Evento del 17 Junio por el cumpleaños de Maria"
            };

            ServiceModel s2 = new ServiceModel()
            {
                Id = 2,
                Name = "Cumpleaños Jose",
                Description = "Evento del 17 Junio por el cumpleaños de Maria"
            };
            ServiceModel s3 = new ServiceModel()
            {
                Id = 3,
                Name = "Evento Final",
                Description = "Evento del 17 Junio por el cumpleaños de Maria"
            };

            List<ServiceModel> model = new List<ServiceModel>();
            model.Add(s1);
            model.Add(s2);
            model.Add(s3);

            return View(model);
        }

        //
        // GET: /Service/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Service/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Service/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Service/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Service/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Service/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Service/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
