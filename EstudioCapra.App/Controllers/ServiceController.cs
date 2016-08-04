using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace EstudioCapra.Controllers
{
    public class ServiceController : Controller
    {
        //
        // GET: /Service/
        public ActionResult Index()
        {
            try
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
                                     IdServicio = x.ServicioId,
                                     FechaInicio = x.FechaInicio,
                                     NombreCiente = y.Nombre,
                                     ApellidoCiente = y.Apellido,
                                     DescripcionServicio = z2.Descripcion

                                 }).ToList();

                    return View(model);
                }

                
            }
            catch (Exception ex)
            {
                ViewBag.ExceptionMessage = ex.Message;
                return View("Error");
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
                             where x.ContratoId == idContrato
                             select new ServiceDetailsModel()
                             {
                                 IdContrato = x.ContratoId,
                                 IdServicio = x.ServicioId,
                                 IdEtapaServicio = z3.ServicioId,
                                 IdEtapa = z3.EtapaId,
                                 NombreEtapa = z4.Nombre,
                                 DescripcionServicio = z2.Descripcion,
                                 NombreServicio = z2.Nombre,
                                 NombreCiente = y.Nombre,
                                 DireccionCiente = y.Direccion,
                                 ApellidoCiente = y.Apellido,
                                 FechaInicioContrato = x.FechaInicio,
                                 ListaEtapas = (from es in context.EtapaServicios
                                                join e in context.Etapas on es.EtapaId equals e.EtapaId
                                                where es.ServicioId == x.ServicioId
                                                select new EtapaModel()
                                                {
                                                    IdEtapa = e.EtapaId,
                                                    NombreEtapa = e.Nombre,
                                                    DescripcionEtapa = e.Descripcion,
                                                    FechaInicioEtapa = e.FechaInicio,
                                                    FechaFinEtapa = e.FechaFin,
                                                    ListaTareas = (from t in context.Tareas
                                                                   join te in context.EtapaTareas on t.TareaId equals te.TareaId
                                                                   join tt in context.TipoTareas on t.TipoTareaId equals tt.TipoTareaId
                                                                   join te1  in context.TareaEmpleadoes on t.TareaId equals te1.TareaId
                                                                   join em in context.Empleadoes on te1.EmpleadoId equals em.EmpleadoId
                                                                   where te.EtapaId == e.EtapaId
                                                                   select new TareaModel()
                                                                    {
                                                                    IdTarea = t.TareaId,
                                                                    NombreTarea = t.Nombre,
                                                                    DescripcionTarea = t.Descripcion,
                                                                    FechaInicioTarea = t.FechaInicio,
                                                                    FechaFinTarea = t.FechaFin,
                                                                    idTipoTarea = tt.TipoTareaId,
                                                                    TemplateTarea = tt.TareaTemplate,
                                                                    IdEmpleado = te1.EmpleadoId,
                                                                    ApellidoEmpleado = em.Apellido,
                                                                    StatusTarea = te1.Status

                                                                    }
                                                                   ).ToList()
                                                }
                                               ).ToList()
                                

                             }
                             ).ToList().FirstOrDefault();

                return View(model);

            }
        }

        //
        // GET: /Service/Create
        public ActionResult Create()
        {
            using (var context = new EstudioCapraEntities())
            {
                ViewBag.Clientes = (from x in context.Clientes select x).ToList();
            }

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
