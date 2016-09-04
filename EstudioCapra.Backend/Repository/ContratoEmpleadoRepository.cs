using EstudioCapra.Entity;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EstudioCapra.Backend.Repository
{
    public class ContratoEmpleadoRepository
    {
        private EstudioCapraEntities _context { get; set; }

        public ContratoEmpleadoRepository(EstudioCapraEntities context)
        {
            this._context = context;
        }

        public List<ContratoEmpleado> GetAll()
        {
            return (from x in _context.ContratoEmpleado select x).ToList();
        }

        public void Add(ContratoEmpleado item)
        {
            try
            {
                _context.ContratoEmpleado.Add(item);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Delete(ContratoEmpleado item)
        {
            try
            {
                _context.ContratoEmpleado.Remove(item);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
