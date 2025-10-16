using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor.Item;

namespace Visitor.Document
{
    public class Hyperlink : DocumentPart
    {
        public string URL { get; private set; }
        public Hyperlink(string url, string text) : base(text) { this.URL = url; }
        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
