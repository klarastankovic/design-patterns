using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator.Entry
{
    public class Journal : IEnumerable<Entry>
    {
        List<Entry> entries;
        public Journal() { entries = new List<Entry>(); }
        public void Save(Entry entry) { entries.Add(entry); }
        public int Total() { return entries.Count; }
        public Entry this[int index] { get { return entries[index]; } }
        public ICustomIterator CreateIterator(int stepSize)
        {
            return new StepIterator(stepSize, this);
        }
        public IEnumerator<Entry> GetEnumerator()
        {
            return new NativeIterator(this);
        }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return new NativeIterator(this);
        }
    }
}
