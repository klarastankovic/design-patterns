using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor.Item
{
    public static class ItemTester
    {
        public static void Test()
        {
            IItem dvd = new DVD("LORT", 15.00, DVDType.MOVIE);
            IItem vhs = new VHS("LORT", 10.00);
            IItem book = new Book("LORT", 13.00);
            /*
            List<IItem> items = new List<IItem>();
            items.Add(dvd);
            items.Add(vhs);
            items.Add(book);
            */
            /*IVisitor buyVisitor = new BuyVisitor();
            foreach(IItem item in items)
            {
                Console.WriteLine(item);
                Console.WriteLine("Price + tax: " + item.Accept(buyVisitor));
                Console.WriteLine();
            }*/
            
            IVisitor rentVisitor = new RentVisitor();
            /*
            foreach(IItem item in items)
            {
                Console.WriteLine(item);
                Console.WriteLine("Renting price: " + item.Accept(rentVisitor));
                Console.WriteLine();
            }*/

            Cart cart = new Cart();
            cart.Add(dvd);
            cart.Add(vhs);
            cart.Add(book);
            Console.WriteLine("Total rent price: " + cart.Accept(rentVisitor));
        }
    }
}
