using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator.Entry
{
    public class StepIterator : ICustomIterator
    {
        public int StepSize { get; private set; }
        public Journal Journal { get; private set; }
        private int CurrentIndex { get; set; }
        public Entry Current { get { return this.Journal[this.CurrentIndex]; } }
        public StepIterator(int stepSize, Journal journal)
        {
            this.StepSize = stepSize;
            this.Journal = journal;
            this.CurrentIndex = 0;
        }
        public bool MoveNext()
        {
            if (this.CurrentIndex + this.StepSize > this.Journal.Total() - 1)
            {
                return false;
            }
            this.CurrentIndex += StepSize;
            return true;
        }
    }
}
