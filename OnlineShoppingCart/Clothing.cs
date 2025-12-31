using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShoppingCart
{
    public class Clothing : Product
    {
        public double Price { get; set; }
        public override double GetPrice()
        {
            return Price * 0.9;
        }
    }
}
