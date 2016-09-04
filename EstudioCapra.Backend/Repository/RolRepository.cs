using EstudioCapra.Entity;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EstudioCapra.Backend.Repository
{
    public class RolRepository
    {
        private EstudioCapraEntities _context { get; set; }

        public RolRepository(EstudioCapraEntities context)
        {
            this._context = context;
        }

        public List<Rol> GetAll()
        {
            return (from x in _context.Rol select x).ToList();
        }

        public void Add(Rol item)
        {
            try
            {
                _context.Rol.Add(item);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Delete(Rol item)
        {
            try
            {
                _context.Rol.Remove(item);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
