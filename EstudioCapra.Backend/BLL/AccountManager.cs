using EstudioCapra.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudioCapra.Backend.BLL
{

    public class AccountManager
    {
        private double TASAPAGOMINIMO = 0.2;

        public int ClientId { get; set; }
        public List<Pago> Pagos { get; set; }
        private IUnitOfWork _UnitOfWork { get; set; }

        public AccountManager(IUnitOfWork unitOfOwork, int clientId)
        {
            this.ClientId = clientId;
            this._UnitOfWork = unitOfOwork;

            var pagosList = _UnitOfWork.PagoRepository.GetAll();

            this.Pagos = (from p in pagosList 
                          where p.ClienteId == clientId
                          select p).ToList();
        }

        public Decimal GetSaldo()
        {
            Decimal total = 0;
            var contractos = from x in _UnitOfWork.ContratoRepository.GetAll()
                             where x.ClienteId == ClientId
                             select x;

            if (contractos.Count() > 0)
            {
                foreach (var contract in contractos)
                {
                    total = total + contract.Costo;

                    foreach (var etapa in contract.Servicio.Etapa.Where(x => x.Estado != "FINALIZADA" && x.Estado != "PAGADO"))
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

        public decimal GetTotalPagosAceptados()
        {
            decimal total = 0;
            foreach (var pago in Pagos)
            {
                if (pago.Estado == "ACEPTADO")
                {
                    total = total + pago.Monto;
                }

            }
            return total;
        }

        public decimal GetTotalPagosPendientes()
        {
            decimal total = 0;
            foreach (var pago in Pagos)
            {
                if (pago.Estado == "PENDIENTE")
                {
                    total = total + pago.Monto;
                }

            }
            return total;
        }

        public decimal GetTotalAcum()
        {
            Decimal total = 0;
            var contractos = from x in _UnitOfWork.ContratoRepository.GetAll()
                             where x.ClienteId == ClientId
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


        public double GetPagoMinimo()
        {
            var total = Convert.ToDouble(GetSaldo()) * TASAPAGOMINIMO;
            return total;
        }
        
    }
}
