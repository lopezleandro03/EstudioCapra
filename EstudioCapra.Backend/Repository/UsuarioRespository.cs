using EstudioCapra.Entity;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EstudioCapra.Backend.Repository
{
    public class UsuarioRepository
    {
        private EstudioCapraEntities _context { get; set; }

        public UsuarioRepository(EstudioCapraEntities context)
        {
            this._context = context;
        }

        public List<Usuario> GetAll()
        {
            return (from x in _context.Usuario select x).ToList();
        }

        public void Add(Usuario item)
        {
            try
            {
                _context.Usuario.Add(item);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Delete(Usuario item)
        {
            try
            {
                _context.Usuario.Remove(item);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
