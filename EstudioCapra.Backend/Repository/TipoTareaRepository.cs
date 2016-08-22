using EstudioCapra.Entity;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EstudioCapra.Backend.Repository
{
    public class TipoTareaRepository
    {
        private EstudioCapraEntities _context
        {
            get;
            set;
        }

        public TipoTareaRepository(EstudioCapraEntities context)
        {
            this._context = context;
        }

        public List<TipoTarea> GetAll()
        {
            return (from x in this._context.TipoTarea
                    select x).ToList<TipoTarea>();
        }

        public void Add(TipoTarea item)
        {
            try
            {
                this._context.TipoTarea.Add(item);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Delete(TipoTarea item)
        {
            try
            {
                this._context.TipoTarea.Remove(item);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
