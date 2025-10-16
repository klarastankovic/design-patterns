using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor.Number
{
    public interface INumericalVisitor
    {
        void Visit(Single oneElement);
        void Visit(Pair twoElement);
    }
}
