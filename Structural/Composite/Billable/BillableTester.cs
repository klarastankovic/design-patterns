using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Billable
{
    public static class BillableTester
    {
        public static void Test()
        {
            Product milk = new Product("Oat Milk", 2.00, 1000);
            Product cheese = new Product("Cheese", 1.50, 250);
            Box box = new Box("Dairy");
            box.Add(milk);
            box.Add(cheese);
            Console.WriteLine(box.Description());
            Console.WriteLine("Total box price: " + box.Price);
            Console.WriteLine("Total box weight: " + box.Weight);

            ShippingService shippingService = new ShippingService(1.25);
            Console.WriteLine("Shipping price: " + shippingService.CalculateShippingPrice(box));
        }
    }
}
