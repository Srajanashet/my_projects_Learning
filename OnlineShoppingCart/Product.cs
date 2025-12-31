using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShoppingCart
{
    public abstract class Product
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public abstract double GetPrice();
    }
}
