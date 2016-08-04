using EstudioCapra.Entity;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EstudioCapra.Backend.Repository
{
    public class TareaEmpleadoRepository
    {
        private EstudioCapraEntities _context { get; set; }

        public TareaEmpleadoRepository(EstudioCapraEntities context)
        {
            this._context = context;
        }

        public List<TareaEmpleado> GetAll()
        {
            return (from x in _context.TareaEmpleado select x).ToList();
        }

        public void Add(TareaEmpleado item)
        {
            try
            {
                _context.TareaEmpleado.Add(item);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Delete(TareaEmpleado item)
        {
            try
            {
                _context.TareaEmpleado.Remove(item);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
