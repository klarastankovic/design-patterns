using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor.Number
{
    public class SumVisitor : INumericalVisitor
    {
        public int TotalSum { get; private set; }
        public SumVisitor() { TotalSum = 0; }
        public void Visit(Single single)
        {
            TotalSum += single.Number;
        }
        public void Visit(Pair pair)
        {
            TotalSum += pair.Number1 + pair.Number2;
        }
    }
}
