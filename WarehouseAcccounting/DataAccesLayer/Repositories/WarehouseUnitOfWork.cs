using DataAccesLayer.Interfaces;
using DataAccesLayer.Models;
using DataAccesLayer.Repositories;
using System;

namespace DataAccesLayer
{
    public class WarehouseUnitOfWork: IWarehouseUnitOfWork
    {
        private DatabaseContext _context;
        private IRepository<Currency> currencyRepository;
        private IRepository<Product> productRepository;
        private bool isDisposed = false;

        public IRepository<Currency> Currencies
        {
            get => currencyRepository ?? (currencyRepository = new WarehouseAccountingRepository<Currency>(_context));
            set => currencyRepository = value;
        }
        public IRepository<Product> Products
        {
            get => productRepository ?? (productRepository = new WarehouseAccountingRepository<Product>(_context));
            set => productRepository = value;
        }

        public WarehouseUnitOfWork()
        {
            _context = new DatabaseContext();
        }

        public void Dispose()
        {
            Dispose(true);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (!isDisposed && disposing)
            {
                _context.Dispose();
                isDisposed = true;
            }
        }
    }
}
