using EstudioCapra.Entity;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EstudioCapra.Backend.Repository
{
    public class EmpleadoRepository
    {
        private EstudioCapraEntities _context
        {
            get;
            set;
        }

        public EmpleadoRepository(EstudioCapraEntities context)
        {
            this._context = context;
        }

        public List<Empleado> GetAll()
        {
            return (from x in this._context.Empleado
                    select x).ToList<Empleado>();
        }

        public void Add(Empleado item)
        {
            try
            {
                this._context.Empleado.Add(item);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Delete(Empleado item)
        {
            try
            {
                this._context.Empleado.Remove(item);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
