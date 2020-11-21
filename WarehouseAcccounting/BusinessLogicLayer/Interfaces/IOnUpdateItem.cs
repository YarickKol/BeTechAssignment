using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogicLayer.Interfaces
{
    public interface IOnUpdateItem<T> where T:class
    {
        bool UpdateItem(string item , decimal value);
    }
}
