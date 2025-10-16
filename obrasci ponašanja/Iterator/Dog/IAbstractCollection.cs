using Iterator.Note;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator.Dog
{
    public interface IAbstractCollection
    {
        IAbstractIterator CreateIterator();
    }
}
