using System;
using System.Collections.Generic;

namespace OnlineShoppingCart
{
    class Program
    {
        static void Main(string[] args)
        {

            Repository<Product> cart= new Repository<Product>();
            Product p1 = new Electronics()
            {
                ProductID=1,
                Name="Laptop",
                Price=60000
            };
            Product p2 = new Clothing()
            {
                ProductID = 2,
                Name = "T shirt",
                Price=2000
            };
            cart.Add(p1);
            cart.Add(p2);
            DiscountService discountService = new DiscountService();
            double total = 0;
            Console.WriteLine("===Cart items===");
            foreach (Product product in cart.Getall())
            {
                double price = product.GetPrice();
                total += price;
                Console.WriteLine($"{product.Name}-₹{price}");
            }
            total = discountService.ApplyDiscount(total);
            Console.WriteLine($"\nFinal Amount After Discount: {total}");
            Utility.PrintItem("Thank you for shopping");
            Console.ReadLine();

        }
    }
}