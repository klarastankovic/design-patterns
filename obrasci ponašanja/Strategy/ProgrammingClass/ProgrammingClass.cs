using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.ProgrammingClass
{
    public class ProgrammingClass
    {
        private List<String> Students {  get; set; }
        public ISortStrategy Strategy { get; set; }
        public ProgrammingClass(List<String> students, ISortStrategy strategy)
        {
            Students = students;
            Strategy = strategy;
        }
        public void Add(string name) { Students.Add(name); }
        public void Sort() { this.Strategy.Sort(Students); }
        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            foreach(string name in Students)
            {
                builder.Append(name + Environment.NewLine);
            }
            return builder.ToString();
        }
    }
}
