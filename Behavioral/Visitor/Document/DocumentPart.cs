using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor.Item;

namespace Visitor.Document
{
    public abstract class DocumentPart
    {
        public string Text { get; private set; }
        public DocumentPart(string text)
        {
            Text = text;
        }
        public abstract void Accept(IVisitor visitor);
    }
}
