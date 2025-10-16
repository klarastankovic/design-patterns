using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor.Item
{
    public class Cart
    {
        private List<IItem> items = new List<IItem>();
        public double Accept(IVisitor visitor)
        {
            double sum = 0.0;
            foreach(IItem item in items)
            {
                sum += item.Accept(visitor);
            }
            return sum;
        }
        public void Add(IItem item) { items.Add(item); }
        public void Remove(IItem item) { items.Remove(item); }
    }
}
