using EstudioCapra.Entity;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EstudioCapra.Backend.Repository
{
    public class ContratoRepository
    {
        private EstudioCapraEntities _context { get; set; }

        public ContratoRepository(EstudioCapraEntities context)
        {
            this._context = context;
        }

        public List<Contrato> GetAll()
        {
            return (from x in _context.Contrato select x).ToList();
        }

        public void Add(Contrato item)
        {
            try
            {
                _context.Contrato.Add(item);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Delete(Contrato item)
        {
            try
            {
                _context.Contrato.Remove(item);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
