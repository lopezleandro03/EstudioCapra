using EstudioCapra.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace EstudioCapra.Backend.Repository
{
    public class ServicioRepository
    {
        private EstudioCapraEntities _context { get; set; }

        public ServicioRepository(EstudioCapraEntities context)
        {
            this._context = context;
        }

        public List<Servicio> GetAll()
        {
            return (from x in _context.Servicio select x).ToList();
        }

        public void Add(Servicio item)
        {
            try
            {
                _context.Servicio.Add(item);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Delete(Servicio item)
        {
            try
            {
                _context.Servicio.Remove(item);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
