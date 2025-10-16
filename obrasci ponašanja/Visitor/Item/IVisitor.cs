using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor.Item
{
    public interface IVisitor
    {
        double Visit(DVD DVDItem);
        double Visit(VHS VHSItem);
        double Visit(Book bookItem);
    }
}
