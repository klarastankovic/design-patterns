using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy.Journal
{
    public class PrivateJournal : IEntryStorage
    {
        Journal journal;
        String password = "password";
        public bool Authenticate(String password)
        {
            if (String.IsNullOrEmpty(password) || this.password != password) { return false; }
            this.journal = new Journal();
            return true;
        }
        public void Save(Entry entry)
        {
            if (this.journal == null) { throw new AccessViolationException("Unauthorised!"); }
            this.journal.Save(entry);
        }
        public IReadOnlyCollection<Entry> Find(DateTime timestamp)
        {
            if (this.journal == null) { throw new AccessViolationException("Unauthorised!"); }
            return this.journal.Find(timestamp);
        }
    }
}
