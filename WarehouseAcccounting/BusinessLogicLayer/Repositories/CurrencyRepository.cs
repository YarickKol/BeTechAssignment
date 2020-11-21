using BusinessLogicLayer.Interfaces;
using DataAccesLayer.Models;
using DataAccesLayer;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace BusinessLogicLayer.Repositories
{
    public class CurrencyRepository : ICurrencyRepository
    {
        private DatabaseContext _context;

        public CurrencyRepository(DatabaseContext context)
        {
            _context = context;
        }
        public bool CreateItem(Currency item)
        {
            if (item == null)
                throw new ArgumentNullException(nameof(item));

            _context.Currencies.Add(item);
            return SaveChanges();
        }

        public IEnumerable<Currency> GetAllItems()
        {
            return _context.Currencies.ToList();
        }

        public Currency GetItemById(int id)
        {
            return _context.Currencies.FirstOrDefault(c => c.Id == id);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

        public bool UpdateItem(string code, decimal value)
        {
            Currency currency = _context.Currencies.FirstOrDefault(c => c.Code == code);
            if (currency != null)
            {
                currency.CurrencyRate = value;
                currency.UpdateDate = DateTime.Now;
                return SaveChanges();
            }
            return false;
        }
    }
}
