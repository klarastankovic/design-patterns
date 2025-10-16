using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor.Number
{
    public class Single : INumerical
    {
        public int Number {  get; private set; }
        public Single(int number)
        {
            Number = number;
        }
        public void Accept(INumericalVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
