using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor.Document
{
    public interface IVisitor
    {
        void Visit(PlainText docPart);
        void Visit(BoldText docPart);
        void Visit(Hyperlink docPart);
    }
}
