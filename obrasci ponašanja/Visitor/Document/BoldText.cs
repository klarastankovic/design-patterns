using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor.Item;

namespace Visitor.Document
{
    public class BoldText : DocumentPart
    {
        public BoldText(string text) : base(text) { }
        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
