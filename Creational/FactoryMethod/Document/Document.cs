using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Document
{
    public abstract class Document
    {
        private List<Page>  pages = new List<Page>();
        public List<Page> Pages { get { return this.pages; } }
        public Document() { this.CreatePages(); }
        protected abstract void CreatePages();
    }
}
