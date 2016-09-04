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

        public ActionResult MyServices()
        {
            try
            {
                var currentUserEmail = base.HttpContext.Session.GetString("USER").ToString();

                var model = (from x in _UnitOfWork.ContratoRepository.GetAll()
                            join y in _UnitOfWork.UsuarioRepository.GetAll()
                            on x.Cliente.UserId equals y.UserId
                            where y.Email == currentUserEmail
                            select new ServiceModel()
                            {
                                IdContrato = x.ContratoId,
                                IdCliente = x.ClienteId,
                                IdServicio = x.ServicioId,
                                FechaInicio = x.FechaInicio,
                                NombreCiente = x.Cliente.Nombre,
                                ApellidoCiente = x.Cliente.Apellido,
                                DescripcionServicio = x.Servicio.Nombre
                            }).ToList();

                return PartialView("Index",model);
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
                             ListaEtapas = (from e in x.Servicio.Etapa
                                            select new EtapaModel()
                                            {
                                                IdEtapa = e.EtapaId,
                                                NombreEtapa = e.Nombre,
                                                DescripcionEtapa = e.Descripcion,
                                                FechaInicioEtapa = e.FechaInicio,
                                                FechaFinEtapa = e.FechaFin,
                                                ListaIdObjetoMultimedia = (from o in e.ObjetoMultimedia
                                                                           select o.ObjetoMultimediaId).ToList(),
                                                ListaTareas = (from t in e.Tarea
                                                               select new TareaModel()
                                                               {
                                                                   IdTarea = t.TareaId,
                                                                   NombreTarea = t.Nombre,
                                                                   DescripcionTarea = t.Descripcion,
                                                                   FechaInicioTarea = t.FechaInicio,
                                                                   FechaFinTarea = t.FechaFin,
                                                                   idTipoTarea = t.TipoTareaId,
                                                                   TemplateTarea = t.TipoTarea.TareaTemplate,
                                                                   ListEmpleado = (from te in _UnitOfWork.TareaEmpleadoRepository.GetAll()
                                                                                   where te.TareaId == t.TareaId
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

            foreach (var item in model.ListaEtapas)
                item.Estado = item.FechaFinEtapa < DateTime.Now ? "done" : (item.FechaInicioEtapa < DateTime.Now && item.FechaFinEtapa > DateTime.Now ? "active" : string.Empty);

            ViewBag.IdContrato = model.IdContrato;
            ViewBag.IdService = model.IdServicio;
            ViewBag.EtapaColSize = Math.Truncate((decimal)12 / model.ListaEtapas.Count);

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
