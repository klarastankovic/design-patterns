using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator.Entry
{
    public class Entry
    {
        public DateTime Timestamp { get; private set; }
        public String Note { get; private set; }
        public Entry(DateTime timestamp, String note)
        {
            Timestamp = timestamp;
            Note = note;
        }
        public override string ToString()
        {
            return this.Timestamp.ToShortDateString() + ": " + this.Note;
        }
    }
}
