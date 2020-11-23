using DataAccesLayer.Models;
using System;

namespace DataAccesLayer.Interfaces
{
    public interface IWarehouseUnitOfWork: IDisposable
    {
        IRepository<Currency> Currencies { get; set; }
        IRepository<Product> Products { get; set; }
    }
}
