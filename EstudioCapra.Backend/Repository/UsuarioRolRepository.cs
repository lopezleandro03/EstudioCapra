using EstudioCapra.Entity;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EstudioCapra.Backend.Repository
{
    public class UsuarioRolRepository
    {
        private EstudioCapraEntities _context { get; set; }

        public UsuarioRolRepository(EstudioCapraEntities context)
        {
            this._context = context;
        }

        public List<UsuarioRol> GetAll()
        {
            return (from x in _context.UsuarioRol select x).ToList();
        }

        public void Add(UsuarioRol item)
        {
            try
            {
                _context.UsuarioRol.Add(item);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Delete(UsuarioRol item)
        {
            try
            {
                _context.UsuarioRol.Remove(item);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
