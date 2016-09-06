using EstudioCapra.Entity;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EstudioCapra.Backend.Repository
{
    public class PagoRepository
    {
        private EstudioCapraEntities _context { get; set; }

        public PagoRepository(EstudioCapraEntities context)
        {
            this._context = context;
        }

        public List<Pago> GetAll()
        {
            return (from x in _context.Pago select x).ToList();
        }

        public void Add(Pago item)
        {
            try
            {
                _context.Pago.Add(item);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Delete(Pago item)
        {
            try
            {
                _context.Pago.Remove(item);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
