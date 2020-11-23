using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogicLayer.ModelDTO
{
    public class ProductDTO
    {      
        public int Id { get; set; }
       
        public string Name { get; set; }

        public decimal BaseCurrencyPrice { get; set; }

        public decimal Price { get; set; }

        public int CategoryId { get; set; }       

        public int CurrencyId { get; set; }       

        public string Barcode { get; set; }

        public int Count { get; set; }  
    }
}
