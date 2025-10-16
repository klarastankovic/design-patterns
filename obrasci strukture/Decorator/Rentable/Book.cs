using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Rentable
{
    public class Book : IRentable
    {
        private readonly double BaseBookPrice = 3.99;
        public String Title { get; private set; }
        public Book(String title)
        {
            this.Title = title;
        }
        public string Description { get { return this.Title; } }
        public double CalculatePrice()
        {
            return this.BaseBookPrice;
        }
    }
}
