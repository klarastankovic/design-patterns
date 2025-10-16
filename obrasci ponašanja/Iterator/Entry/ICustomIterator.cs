using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator.Entry
{
    public interface ICustomIterator
    {
        bool MoveNext();
        Entry Current { get; }
    }
}
