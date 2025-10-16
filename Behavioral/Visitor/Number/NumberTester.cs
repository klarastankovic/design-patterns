using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor.Number
{
    public static class NumberTester
    {
        public static void Test()
        {
            Pair pair1 = new Pair(3,3);
            Pair pair2 = new Pair(2,7);
            Single single = new Single(3);
            List<INumerical> data = new List<INumerical>();
            data.Add(pair1);
            data.Add(pair2);
            data.Add(single);
            Console.WriteLine("Visiting element list with SumVisitor");
            INumericalVisitor sumVisitor = new SumVisitor();
            foreach(INumerical numerical in data)
            {
                numerical.Accept(sumVisitor);
            }
            Console.WriteLine("Total sum: " + ((SumVisitor)sumVisitor).TotalSum);
        }
    }
}
