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
                var model = (from x in context.Contratoes
                             join y in context.Clientes on x.ClienteId equals y.ClienteId
                             join z in context.Servicios on x.ServicioId equals z.ServicioId
                             join z2 in context.TipoServicios on z.TipoServicioId equals z2.TipoServicioId
                             select new ServiceModel()
                             {
                                 IdContrato = x.ContratoId,
                                 IdCliente = x.ClienteId,
                                 IdServicio  = x.ServicioId,
                                 FechaInicio = x.FechaInicio,
                                 NombreCiente = y.Nombre,
                                 ApellidoCiente = y.Apellido,
                                 DescripcionServicio = z2.Descripcion

                             }).ToList();
                return View(model);
            }
        }

        //
        // GET: /Service/Details/5
        public ActionResult Details(int idContrato)
        {
            using (var context = new EstudioCapraEntities())
            {
                var model = (from x in context.Contratoes
                             join y in context.Clientes on x.ClienteId equals y.ClienteId
                             join z in context.Servicios on x.ServicioId equals z.ServicioId
                             join z2 in context.TipoServicios on z.TipoServicioId equals z2.TipoServicioId
                             join z3 in context.EtapaServicios on x.ServicioId equals z3.ServicioId
                             join z4 in context.Etapas on z3.EtapaId equals z4.EtapaId
                             select new ServiceDetailsModel()
                             {
                                 IdContrato = x.ContratoId,
                                 IdServicio  = x.ServicioId,
                                 IdEtapaServicio = z3.ServicioId,
                                 IdEtapa = z3.EtapaId,
                                 NombreEtapa = z4.Nombre,
                                 DescripcionEtapa = z4.Descripcion,
                                 FechaInicioEtapa = z4.FechaInicio,
                                 FechaFinEtapa = z4.FechaFin,
                                 IdCliente = x.ClienteId,
                                 FechaInicioContrato = x.FechaInicio,
                                 NombreCiente = y.Nombre,
                                 ApellidoCiente = y.Apellido,
                                 DescripcionServicio = z2.Descripcion
                                 }
                             ).ToList();
                return View(model);

            }
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
