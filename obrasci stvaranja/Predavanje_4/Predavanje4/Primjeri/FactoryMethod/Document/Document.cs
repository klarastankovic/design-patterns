using System.Collections.Generic;

namespace Primjeri.FactoryMethod.Document
{
    public abstract class Document
    {
        private List<Page> pages = new List<Page>();
        public List<Page> Pages { get { return this.pages; } }
        // Constructor for Document calls the abstract factory method:
        public Document() { this.CreatePages(); }
        // Anstract factory method:
        protected abstract void CreatePages();
    }
}
