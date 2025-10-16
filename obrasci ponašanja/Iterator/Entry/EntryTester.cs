using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Iterator.Entry
{
    public static class EntryTester
    {
        public static void Test()
        {
            /*
            Journal journal = new Journal();
            journal.Save(new Entry(new DateTime(2017, 12, 15), "Once a upon a time."));
            journal.Save(new Entry(new DateTime(2017, 12, 14), "In a galaxy far away."));
            journal.Save(new Entry(new DateTime(2017, 12, 16), "Spoiler alert."));
            journal.Save(new Entry(new DateTime(2017, 12, 17), "Darth Vader dies."));
            int stepSize = 2;
            ICustomIterator iterator = journal.CreateIterator(stepSize);
            Console.WriteLine("Custom, step size = {0}: ", stepSize);
            do
            {
                Console.WriteLine(iterator.Current);
            } while(iterator.MoveNext());
            */
            Journal journal = new Journal();
            journal.Save(new Entry(new DateTime(2017, 12, 15), "Once a upon a time."));
            journal.Save(new Entry(new DateTime(2017, 12, 14), "In a galaxy far away."));
            journal.Save(new Entry(new DateTime(2017, 12, 16), "Spoiler alert."));
            journal.Save(new Entry(new DateTime(2017, 12, 17), "Darth Vader dies."));
            Console.WriteLine("Native: ");
            foreach(Entry entry in journal)
            {
                Console.WriteLine(entry);
            }
        }
    }
}
