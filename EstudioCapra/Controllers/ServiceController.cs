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
            using (var context = new EstudioCapraEntities())
            {
                var model = (from x in context.Servicios
                             select new ServiceModel()
                             {
                                 Id = x.ServicioId,
                                 Description = "Test EF Desc",
                                 Name = "Test EF"
                             }).ToList();
                return View(model);
            }
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
                var service = new Servicio()
                {
                    TipoServicio = new TipoServicio() { Nombre = "test" },
                    Contratoes = new List<Contrato>(){ new Contrato(){ 
                        ClienteId = 1,
                        ContratoId = 1,
                        Costo = 111111,
                        FechaCalculoSaldo = DateTime.Now
                    }}
                };


                using (var context = new EstudioCapraEntities())
                {
                    context.Servicios.Add(service);
                }

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
