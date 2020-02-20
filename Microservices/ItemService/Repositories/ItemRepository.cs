using ItemService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ItemService.Repositories
{
    public class ItemRepository : IItemRepo
    {
        private readonly ShopDBContext _context;
        public ItemRepository(  ShopDBContext context)
        {
            this._context = context;
      
        }
        public void AddItem(Items obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
            
        }

        public void DeleteItem(string id)
        {
            Items items = _context.Items.Find(id);
            _context.Remove(items);
            _context.SaveChanges();
            throw new NotImplementedException();
        }

        public List<Items> GetAllItems()
        {
            return _context.Items.ToList();
            throw new NotImplementedException();
        }

        public Items GetById(string id)
        {
            return _context.Items.Find(id);
            throw new NotImplementedException();
        }

        public void UpdateItem(Items obj)
        {
            _context.Items.Update(obj);
            _context.SaveChanges();
            
            throw new NotImplementedException();
        }
    }
}
