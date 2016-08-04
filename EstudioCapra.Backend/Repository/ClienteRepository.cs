using EstudioCapra.Entity;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EstudioCapra.Backend.Repository
{
    public class ClienteRepository
    {
        private EstudioCapraEntities _context { get; set; }

        public ClienteRepository(EstudioCapraEntities context)
        {
            this._context = context;
        }

        public List<Cliente> GetAll()
        {
            return (from x in _context.Cliente select x).ToList();
        }

        public void Add(Cliente item)
        {
            try
            {
                _context.Cliente.Add(item);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Delete(Cliente item)
        {
            try
            {
                _context.Cliente.Remove(item);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
