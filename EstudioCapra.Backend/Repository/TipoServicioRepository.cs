using EstudioCapra.Entity;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EstudioCapra.Backend.Repository
{
    public class TipoServicioRepository
    {
        private EstudioCapraEntities _context { get; set; }

        public TipoServicioRepository(EstudioCapraEntities context)
        {
            this._context = context;
        }

        public List<TipoServicio> GetAll()
        {
            return (from x in _context.TipoServicio select x).ToList();
        }

        public void Add(TipoServicio item)
        {
            try
            {
                _context.TipoServicio.Add(item);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Delete(TipoServicio item)
        {
            try
            {
                _context.TipoServicio.Remove(item);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
