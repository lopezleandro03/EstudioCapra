using EstudioCapra.Models;
using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using EstudioCapra.WebApp.Controllers;
using EstudioCapra.Backend;
using EstudioCapra.Model.Empleado;
using Microsoft.AspNetCore.Http;

namespace EstudioCapra.Controllers
{
    public class ServiceController : BaseController
    {

        public ServiceController(IUnitOfWork unitOfWork)
        {
            _UnitOfWork = unitOfWork;
        }
        //
        // GET: /Service/
        public ActionResult Index()
        {
            try
            {
                var model = from x in _UnitOfWork.ContratoRepository.GetAll()
                            select new ServiceModel()
                            {
                                IdContrato = x.ContratoId,
                                IdCliente = x.ClienteId,
                                IdServicio = x.ServicioId,
                                FechaInicio = x.FechaInicio,
                                NombreCiente = x.Cliente.Nombre,
                                ApellidoCiente = x.Cliente.Apellido,
                                DescripcionServicio = x.Servicio.Nombre
                            };

                return PartialView(model);
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
            var model = (from x in _UnitOfWork.ContratoRepository.GetAll()
                         where x.ContratoId == idContrato
                         select new ServiceDetailsModel()
                         {
                             IdContrato = x.ContratoId,
                             IdServicio = x.ServicioId,
                             DescripcionServicio = x.Servicio.TipoServicio.Descripcion,
                             NombreServicio = x.Servicio.TipoServicio.Nombre,
                             NombreCiente = x.Cliente.Nombre,
                             DireccionCiente = x.Cliente.Direccion,
                             ApellidoCiente = x.Cliente.Apellido,
                             FechaInicioContrato = x.FechaInicio,
                             ListaEtapas = (from es in _UnitOfWork.EtapaServicioRepository.GetAll()
                                            where es.ServicioId == x.ServicioId
                                            select new EtapaModel()
                                            {
                                                IdEtapa = es.EtapaId,
                                                NombreEtapa = es.Etapa.Nombre,
                                                DescripcionEtapa = es.Etapa.Descripcion,
                                                FechaInicioEtapa = es.Etapa.FechaInicio,
                                                FechaFinEtapa = es.Etapa.FechaFin,
                                                ListaTareas = (from et in _UnitOfWork.EtapaTareaRepository.GetAll()
                                                               where et.EtapaId == es.EtapaId
                                                               select new TareaModel()
                                                               {
                                                                   IdTarea = et.TareaId,
                                                                   NombreTarea = et.Tarea.Nombre,
                                                                   DescripcionTarea = et.Tarea.Descripcion,
                                                                   FechaInicioTarea = et.Tarea.FechaInicio,
                                                                   FechaFinTarea = et.Tarea.FechaFin,
                                                                   idTipoTarea = et.Tarea.TipoTareaId,
                                                                   TemplateTarea = et.Tarea.TipoTarea.TareaTemplate,
                                                                   ListEmpleado = (from te in _UnitOfWork.TareaEmpleadoRepository.GetAll()
                                                                                   where te.TareaId == et.TareaId
                                                                                   select new EmpleadoModel()
                                                                                   {
                                                                                       EmpleadoId = te.EmpleadoId,
                                                                                       Nombre = te.Empleado.Nombre,
                                                                                       Apellido = te.Empleado.Apellido,
                                                                                       ContratoId = te.Empleado.ContratoId,
                                                                                       Especializacion = te.Empleado.Especializacion,
                                                                                       UserId = te.Empleado.UserId
                                                                                   }).ToList()
                                                               }).ToList()
                                            }).ToList()


                         }).ToList().FirstOrDefault();

            return View(model);

        }

        //
        // GET: /Service/Create
        public ActionResult Create()
        {
            ViewBag.Clientes = (from x in _UnitOfWork.ClienteRepository.GetAll() select x).ToList();
            return View();
        }

        //
        // POST: /Service/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
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
