using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.ProgrammingClass
{
    public static class ProgrammingClassTester
    {
        public static void Test()
        {
            List<String> students = new List<string>()
            {
                "Marija", "Ana", "Lucija", "Dijana", "Bero"
            };
            ISortStrategy strategy = new AscendingSort();
            ProgrammingClass rppoon = new ProgrammingClass(students, strategy);
            rppoon.Sort();
            Console.WriteLine(rppoon);
            rppoon.Strategy = new DescendingSort();
            rppoon.Sort();
            Console.WriteLine(rppoon);
        }
    }
}
