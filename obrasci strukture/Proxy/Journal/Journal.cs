using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy.Journal
{
    public class Journal : IEntryStorage
    {
        List<Entry> entries;
        public Journal()
        {
            entries = new List<Entry>();
        }
        public void Save(Entry entry) { entries.Add(entry); }
        public IReadOnlyCollection<Entry> Find(DateTime timestamp)
        {
            return new ReadOnlyCollection<Entry>(this.entries.Where(s => s.Timestamp.Date == timestamp.Date).ToList());
        }
    }
}
