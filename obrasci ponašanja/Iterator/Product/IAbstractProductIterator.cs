using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator.Product
{
    public interface IAbstractProductIterator
    {
        Product First();
        Product Next();
        bool IsDone { get; }
        Product Current { get; }
    }
}
