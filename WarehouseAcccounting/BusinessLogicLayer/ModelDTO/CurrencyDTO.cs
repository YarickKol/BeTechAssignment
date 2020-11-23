using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogicLayer.ModelDTO
{
    public class CurrencyDTO
    {            
        public string Name { get; set; }
       
        public string Code { get; set; }
       
        public decimal CurrencyRate { get; set; }

        public DateTime UpdateDate { get; set; }
    }
}
