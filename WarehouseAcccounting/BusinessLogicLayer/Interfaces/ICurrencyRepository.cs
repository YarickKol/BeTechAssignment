using DataAccesLayer.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogicLayer.Interfaces
{
    public interface ICurrencyRepository: IDefaultActions<Currency>, IOnUpdateItem<Currency>
    {

    }
}
