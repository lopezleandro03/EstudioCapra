using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EstudioCapra.Models
{
    public class TareaModel
    {
        public int IdTarea { get; set; }
        public string NombreTarea { get; set; }
        public string DescripcionTarea { get; set; }
        public DateTime FechaInicioTarea { get; set; }
        public DateTime? FechaFinTarea { get; set; }
        public int IdTareaPadre { get; set; }
        public int idTipoTarea { get; set; }
        public string TemplateTarea { get; set; }
        public string NombreTipoTarea { get; set; }
        public int IdTareaEmpleado { get; set; }
        public int IdEmpleado { get; set; }
        public string ApellidoEmpleado { get; set; }
        public string NombreEmpleado { get; set; }
        public string StatusTarea { get; set; }
        public int IdEtapaTarea { get; set; }
    }
}