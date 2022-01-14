using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab14WpfApp_hw
{
    public enum ProductTypes
    {
        Food,
        NonFood
    }

    public class Product
    {
        public string Name { get; set; }
        public string ImagePath { get; set; }
        public int Price { get; set; }
        public ProductTypes ProductType { get; set; }        
    }
}
