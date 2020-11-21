using System.Collections.Generic;

namespace BusinessLogicLayer.Interfaces
{
    public interface IDefaultActions<T> where T : class
    {       
        bool SaveChanges();       
        IEnumerable<T> GetAllItems();       
        T GetItemById(int id);
        bool CreateItem(T item);
        
    }
}
