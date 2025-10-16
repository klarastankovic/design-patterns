using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy.Journal
{
    public interface IEntryStorage
    {
        void Save(Entry entry);
        IReadOnlyCollection<Entry> Find(DateTime timestamp);
    }
}
