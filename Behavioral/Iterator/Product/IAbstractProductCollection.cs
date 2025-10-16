using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator.Product
{
    public interface IAbstractProductCollection
    {
        IAbstractProductIterator GetIterator();
    }
}
