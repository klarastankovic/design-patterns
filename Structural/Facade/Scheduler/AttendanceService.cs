using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Scheduler
{
    public class AttendanceService
    {
        int minimum = 70;
        Dictionary<String, int> attendance = new Dictionary<String, int>
        {
            { "PR112", 100 }, { "PEK113", 70 }, { "PR150", 70 }
        };
        public bool HasAttendedEnoughClasses(String id)
        {
            int points = this.attendance[id];
            return points >= this.minimum;
        }
    }
}
