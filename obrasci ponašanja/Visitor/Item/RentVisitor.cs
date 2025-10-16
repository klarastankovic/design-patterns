using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor.Item
{
    public class RentVisitor : IVisitor
    {
        private const double rent = 0.1;
        public double Visit(DVD item)
        {
            if (item.Type == DVDType.SOFTWARE)
                return item.Price;
            return item.Price * rent;
        }
        public double Visit(VHS item)
        {
            return item.Price * rent;
        }
        public double Visit(Book item)
        {
            return item.Price * rent;
        }
    }
}
