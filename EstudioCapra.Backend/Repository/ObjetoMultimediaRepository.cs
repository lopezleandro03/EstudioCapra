using EstudioCapra.Entity;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EstudioCapra.Backend.Repository
{
    public class ObjetoMultimediaRepository
    {
        private EstudioCapraEntities _context
        {
            get;
            set;
        }

        public ObjetoMultimediaRepository(EstudioCapraEntities context)
        {
            this._context = context;
        }

        public List<ObjetoMultimedia> GetAll()
        {
            return (from x in this._context.ObjetoMultimedia
                    select x).ToList<ObjetoMultimedia>();
        }

        public ObjetoMultimedia Get(int Id)
        {
            return this._context.ObjetoMultimedia.Find(new object[]
            {
                Id
            });
        }

        public void Add(ObjetoMultimedia item)
        {
            try
            {
                this._context.ObjetoMultimedia.Add(item);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Delete(ObjetoMultimedia item)
        {
            try
            {
                this._context.ObjetoMultimedia.Remove(item);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
