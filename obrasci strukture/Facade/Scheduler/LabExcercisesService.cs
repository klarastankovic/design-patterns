using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Scheduler
{
    public class LabExcercisesService
    {
        int minimum = 50;
        Dictionary<String, int> excercises = new Dictionary<String, int>
        {
            { "PR112", 70 }, { "PEK113", 70 }, { "PR150", 70 }
        };
        public bool HasEnoughPoints(String id)
        {
            int points = this.excercises[id];
            return points >= minimum;
        }
    }
}
