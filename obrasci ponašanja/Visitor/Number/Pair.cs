using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor.Number
{
    public class Pair : INumerical
    {
        public int Number1 { get; private set; }
        public int Number2 { get; private set; }
        public Pair(int number1, int number2)
        {
            Number1 = number1;
            Number2 = number2;
        }
        public void Accept(INumericalVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
