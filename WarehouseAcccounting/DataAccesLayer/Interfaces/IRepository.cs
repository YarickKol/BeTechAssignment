using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace DataAccesLayer.Interfaces
{
    public interface IRepository<T> where T : class
    {       
        bool SaveChanges();       
        IEnumerable<T> GetAllItems();       
        T GetSingleItem(Expression<Func<T, bool>> predicate);
        void CreateItem(T item);
        void UpdateItem(T item);
        void DeleteItem(T item);
    }
}
