using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace EstudioCapra.Models
{
    public class ServiceDetailsModel
    {
        public int IdContrato { get; set; }
        public int IdCliente { get; set; }
        public int IdServicio { get; set; }
        [Display(Name = "Servicio")]
        public string DescripcionServicio { get; set; }
        [Display(Name = "Nombre")]
        public string NombreCiente { get; set; }
        [Display(Name = "Apellido")]
        public string ApellidoCiente { get; set; }
        public DateTime FechaInicioContrato { get; set; }
        public int IdEtapaServicio { get; set; }
        public int IdEtapa { get; set; }
        public string  NombreEtapa { get; set; }
        public string DescripcionEtapa { get; set; }
        public DateTime FechaInicioEtapa { get; set; }
        public DateTime ?FechaFinEtapa { get; set; }
                          
    }
}