using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator.Product
{
    public static class ProductTester
    {
        public static void Test()
        {
            Box box = new Box();
            box.AddProduct(new Product("Laptop", 2000.0));
            box.AddProduct(new Product("Phone", 1000.0));
            box.AddProduct(new Product("TV", 1500.0));
            IAbstractProductIterator iterator = box.GetIterator();
            for (Product product = iterator.First(); iterator.IsDone == false;  product = iterator.Next())
            {
                Console.WriteLine(product);
            }
        }
    }
}
