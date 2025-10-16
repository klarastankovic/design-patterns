using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator.Entry
{
    public class NativeIterator : IEnumerator<Entry>
    {
        public Journal Journal { get; private set; }
        private int CurrentIndex { get; set; }
        public NativeIterator(Journal journal)
        {
            Journal = journal;
            this.CurrentIndex = -1;
        }
        public Entry Current
        {
            get
            {
                try { return Journal[this.CurrentIndex]; }
                catch (IndexOutOfRangeException) { throw new InvalidOperationException(); }
            }
        }
        object IEnumerator.Current { get { return this.Journal[this.CurrentIndex]; } }
        public void Dispose() { }
        public bool MoveNext()
        {
            this.CurrentIndex++;
            return (this.CurrentIndex < Journal.Total());
        }
        public void Reset()
        {
            this.CurrentIndex = -1;
        }
    }
}
