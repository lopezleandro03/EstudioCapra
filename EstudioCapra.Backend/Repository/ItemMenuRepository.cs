using EstudioCapra.Entity;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EstudioCapra.Backend.Repository
{
    public class ItemMenuRepository
    {
        private EstudioCapraEntities _context { get; set; }

        public ItemMenuRepository(EstudioCapraEntities context)
        {
            this._context = context;
        }

        public List<ItemMenu> GetAll()
        {
            return (from x in _context.ItemMenu select x).ToList();
        }

        public void Add(ItemMenu item)
        {
            try
            {
                _context.ItemMenu.Add(item);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Delete(ItemMenu item)
        {
            try
            {
                _context.ItemMenu.Remove(item);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
