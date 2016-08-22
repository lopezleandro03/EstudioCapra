using EstudioCapra.Model.Empleado;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EstudioCapra.Models
{
    public class TareaModel
    {
        public int IdTarea
        {
            get;
            set;
        }

        [Display(Name = "Nombre")]
        public string NombreTarea
        {
            get;
            set;
        }

        public string DescripcionTarea
        {
            get;
            set;
        }

        [Display(Name = "Fecha Inicio")]
        public DateTime FechaInicioTarea
        {
            get;
            set;
        }

        [Display(Name = "Fecha Fin")]
        public DateTime FechaFinTarea
        {
            get;
            set;
        }

        public int IdTareaPadre
        {
            get;
            set;
        }

        [Display(Name = "Tipo Tarea")]
        public int idTipoTarea
        {
            get;
            set;
        }

        public string TemplateTarea
        {
            get;
            set;
        }

        public string NombreTipoTarea
        {
            get;
            set;
        }

        public int IdTareaEmpleado
        {
            get;
            set;
        }

        public List<EmpleadoModel> ListEmpleado
        {
            get;
            set;
        }

        public int ContratoId
        {
            get;
            set;
        }

        public List<int> ListaEmpleadoId
        {
            get;
            set;
        }

        public int EtapaId
        {
            get;
            set;
        }
    }
}
