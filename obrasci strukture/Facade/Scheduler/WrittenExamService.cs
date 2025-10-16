using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Scheduler
{
    public class WrittenExamService
    {
        int minimum = 50;
        Dictionary<String, int> examPoints = new Dictionary<String, int>
        {
            { "PR112", 30 }, { "PEK113", 70 }, { "PR150", 70 }
        };
        public bool PassedWrittenExam(String id)
        {
            int points = this.examPoints[id];
            return points >= minimum;
        }
    }
}
