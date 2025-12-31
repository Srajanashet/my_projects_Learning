using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShoppingCart
{
    public class DiscountService : IDiscount
    {
        private double discountRate = 0.05;
        public double ApplyDiscount(double amount)
        {
            return amount - (amount * discountRate);
        }
    }
}
