using EstudioCapra.Backend;
using EstudioCapra.Entity;
using EstudioCapra.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Routing;
using Microsoft.CSharp.RuntimeBinder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace EstudioCapra.WebApp.Controllers
{
    public class TareaController : BaseController
    {
        public TareaController(IUnitOfWork unitOfWork)
        {
            base._UnitOfWork = unitOfWork;
        }

        public PartialViewResult Create()
        {
            List<SelectListItem> ListaTipoTarea = (from x in _UnitOfWork.TipoTareaReposiory.GetAll()
                                                   select new SelectListItem()
                                                   {
                                                       Text = x.Nombre,
                                                       Value = x.TipoTareaId.ToString()
                                                   }).ToList();

            ViewBag.SelectTipoTarea = ListaTipoTarea;

            List<SelectListItem> ListaEmpleado = (from x in _UnitOfWork.EmpleadoRepository.GetAll()
                                                  select new SelectListItem()
                                                  {
                                                      Text = x.Nombre + " " + x.Apellido + " [" + x.Especializacion + "]",
                                                      Value = x.EmpleadoId.ToString()
                                                  }).ToList();

            ViewBag.SelectEmpleado = ListaEmpleado;

            return this.PartialView();
        }

        [HttpPost]
        public ActionResult Create(TareaModel model)
        {
            Tarea tarea = new Tarea
            {
                Nombre = model.NombreTarea,
                Descripcion = model.DescripcionTarea,
                FechaInicio = model.FechaInicioTarea,
                FechaFin = model.FechaFinTarea,
                TareaPadreId = null,
                TipoTareaId = model.idTipoTarea,
                EtapaId = model.EtapaId
            };

            _UnitOfWork.TareaRespository.Add(tarea);

            foreach (int item in model.ListaEmpleadoId)
            {
                _UnitOfWork.TareaEmpleadoRepository.Add(new TareaEmpleado
                {
                    EmpleadoId = item,
                    TareaId = tarea.TareaId,
                    Estado = "Pendiente"
                });
            }

            _UnitOfWork.Save();

            return this.RedirectToAction("Details", new RouteValueDictionary(new
            {
                controller = "Service",
                action = "Details",
                idContrato = model.ContratoId
            }));
        }
    }
}
