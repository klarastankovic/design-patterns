using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Rentable
{
    public static class RentableTester
    {
        public static void Test()
        {
            List<IRentable> items = new List<IRentable>();
            items.Add(new Book("LOTR"));
            items.Add(new Video("Materialists"));
            items.Add(new HotItem(new Book("Witch of the Gritch")));
            items.Add(new HotItem(new Video("Anyone but you")));
            RentingConsolePrinter printer = new RentingConsolePrinter();
            printer.DisplayItems(items);
            printer.PrintTotalPrice(items);

            List<IRentable> flashSale = new List<IRentable>();
            foreach (IRentable item in items)
            {
                flashSale.Add(new DiscountedItem(20.00, item));
            }
            printer.DisplayItems(flashSale);
            printer.PrintTotalPrice(flashSale);
        }
    }
}
