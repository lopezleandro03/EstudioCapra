using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace EstudioCapra.WebApp.Controllers
{
    public class AccountController : BaseController
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        private Decimal CalcularTotal()
        {
            Decimal total = 0;
            var user = base.HttpContext.Session.GetString("USER");
            var contractos = from x in _UnitOfWork.ContratoRepository.GetAll()
                            join y in _UnitOfWork.UsuarioRepository.GetAll() on x.Cliente.UserId equals y.UserId
                            where y.Email == user
                            select x;

            if (contractos.Count() > 0)
            {
                foreach (var contract in contractos)
                {
                    total = total + contract.Costo;
                    foreach (var etapa in contract.Servicio.Etapa)
                    {
                        total = total + etapa.CostoBase;

                        foreach (var tarea in etapa.Tarea)
                        {
                            total = total + tarea.Costo;

                            foreach (var empleado in (from te in _UnitOfWork.TareaEmpleadoRepository.GetAll()
                                                      join ce in _UnitOfWork.ContratoEmpleadoRepository.GetAll() on te.EmpleadoId equals ce.EmpleadoId
                                                      where te.TareaId == tarea.TareaId
                                                      select ce).ToList())
                            {
                                //Calculo total costo empleado
                                total = empleado.Tipo.ToUpper() == "TEMPORAL" ? 
                                    total + (empleado.CostoHora * Math.Abs(tarea.Horas)) : 
                                    total + (empleado.Salario / 20);
                            }

                        }

                        //por cada recurso fisico, se suma al total;

                    }
                }
            }
            else
            {
                total = 0;
            }
            return total;
        }

    }
}
