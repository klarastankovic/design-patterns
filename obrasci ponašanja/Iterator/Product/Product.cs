using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator.Product
{
    public class Product
    {
        public string Description { get; private set; }
        public double Price { get; private set; }
        public Product(string description, double price)
        {
            Description = description;
            Price = price;
        }
        public override string ToString()
        {
            return this.Description + ":\n" + this.Price;
        }
    }
}
