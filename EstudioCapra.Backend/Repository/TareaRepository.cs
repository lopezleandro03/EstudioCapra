using EstudioCapra.Entity;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EstudioCapra.Backend.Repository
{
    public class TareaRepository
    {
        private EstudioCapraEntities _context
        {
            get;
            set;
        }

        public TareaRepository(EstudioCapraEntities context)
        {
            this._context = context;
        }

        public List<Tarea> GetAll()
        {
            return (from x in this._context.Tarea
                    select x).ToList<Tarea>();
        }

        public void Add(Tarea item)
        {
            try
            {
                this._context.Tarea.Add(item);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Delete(Tarea item)
        {
            try
            {
                this._context.Tarea.Remove(item);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
