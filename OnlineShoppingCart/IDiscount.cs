using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShoppingCart
{
    public interface IDiscount
    {
        double ApplyDiscount(double amount);
    }
}
