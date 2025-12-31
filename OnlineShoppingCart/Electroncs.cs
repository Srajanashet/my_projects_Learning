using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShoppingCart
{
    public class Electronics : Product
    {
        public double Price { get; set; }
        public override double GetPrice()
        {
            
            return Price;
        }
    }
}
