using EstudioCapra.Entity;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EstudioCapra.Backend.Repository
{
    public class EtapaTareaRepository
    {
        private EstudioCapraEntities _context { get; set; }

        public EtapaTareaRepository(EstudioCapraEntities context)
        {
            this._context = context;
        }

        public List<EtapaTarea> GetAll()
        {
            return (from x in _context.EtapaTarea select x).DefaultIfEmpty().ToList();
        }

        public void Add(EtapaTarea item)
        {
            try
            {
                _context.EtapaTarea.Add(item);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Delete(EtapaTarea item)
        {
            try
            {
                _context.EtapaTarea.Remove(item);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

