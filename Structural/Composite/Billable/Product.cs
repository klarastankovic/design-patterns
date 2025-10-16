using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Billable
{
    public class Product : IShipable // list
    {
        private double price;
        private double weight;
        private string description;
        public Product (string description, double price, double weight)
        {
            this.description = description;
            this.price = price;
            this.weight = weight;
        }
        public double Price { get { return price; } }
        public double Weight { get { return weight; } }
        public string Description(int depth = 0)
        {
            return new string(' ', depth) + this.description;
        }
    }
}
