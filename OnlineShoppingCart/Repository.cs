using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShoppingCart
{
  public class Repository<T>
    {
        private List<T> items =new List<T>();
        public void Add(T item)
        {
            items.Add(item);    
        }
        public List<T> Getall()
        {
            return items;
        }
    }
}
