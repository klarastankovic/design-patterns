using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator.Dog
{
    public interface IAbstractIterator
    {
        Dog First();
        Dog Next();
        bool IsDone { get; }
        Dog CurrentDog { get; }
    }
}
