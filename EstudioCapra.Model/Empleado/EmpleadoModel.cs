using System;

namespace EstudioCapra.Model.Empleado
{
    public class EmpleadoModel
    {
        public int EmpleadoId
        {
            get;
            set;
        }

        public string Nombre
        {
            get;
            set;
        }

        public string Apellido
        {
            get;
            set;
        }

        public string Especializacion
        {
            get;
            set;
        }

        public int ContratoId
        {
            get;
            set;
        }

        public int? UserId
        {
            get;
            set;
        }
    }
}
