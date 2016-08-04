using EstudioCapra.Entity;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EstudioCapra.Backend.Repository
{
    public class EtapaServicioRepository
    {
        private EstudioCapraEntities _context { get; set; }

        public EtapaServicioRepository(EstudioCapraEntities context)
        {
            this._context = context;
        }

        public List<EtapaServicio> GetAll()
        {
            return (from x in _context.EtapaServicio select x).ToList();
        }

        public void Add(EtapaServicio item)
        {
            try
            {
                _context.EtapaServicio.Add(item);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Delete(EtapaServicio item)
        {
            try
            {
                _context.EtapaServicio.Remove(item);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

