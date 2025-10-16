using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.ProgrammingClass
{
    public class AscendingSort : ISortStrategy
    {
        public void Sort(List<string> list)
        {
            list.Sort();
        }
    }
}
