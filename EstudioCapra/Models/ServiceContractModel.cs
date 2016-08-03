using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace EstudioCapra.Models
{
    public class ServiceContractModel
    {
        public string Nombre { get; set; }
        public int ContratoId { get; set; }
        public int ClienteId { get; set; }
        public int ClienteNombre { get; set; }
        public int ServicioId { get; set; }
        public decimal Costo { get; set; }
        public System.DateTime FechaInicio { get; set; }
        public System.DateTime FechaFin { get; set; }
        public decimal Saldo { get; set; }
        public System.DateTime FechaCalculoSaldo { get; set; }
    }
}