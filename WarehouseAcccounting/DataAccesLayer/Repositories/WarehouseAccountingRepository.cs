using DataAccesLayer.Interfaces;
using DataAccesLayer.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace DataAccesLayer.Repositories
{
    public class WarehouseAccountingRepository<T> : IRepository<T> where T:class
    {
        private DatabaseContext _context;

        public WarehouseAccountingRepository(DatabaseContext context)
        {
            _context = context;
        }

        public void CreateItem(T item)
        {
            _context.Entry(item).State = EntityState.Added;           
        }

        public void DeleteItem(T item)
        {           
            _context.Entry(item).State = EntityState.Deleted;            
        }

        public IEnumerable<T> GetAllItems()
        {
            IEnumerable<T> items = _context.Set<T>().AsEnumerable();
            if (items.Count() == 0)
                throw new Exception();
            return items;
        }

        public T GetSingleItem(Expression<Func<T, bool>> predicate)
        {
            T item = _context.Set<T>().FirstOrDefault(predicate);
            if (item == null)
                throw new Exception("Not found");
            return item;
            
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

        public void UpdateItem(T item)
        {           
            _context.Entry(item).State = EntityState.Modified;
        }
    }
}
