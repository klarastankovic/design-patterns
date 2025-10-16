using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Scheduler
{
    public static class SchedulerTester
    {
        public static void Test()
        {
            OralExamScheduler scheduler = new OralExamScheduler();
            List<String> ids = new List<string>() { "PR112", "PEK113", "PR150" };
            foreach (String id in ids)
            {
                if (scheduler.IsEligibleForOralExam(id))
                    Console.WriteLine(id + ", please enter and pick a card.");
                else
                    Console.WriteLine(id + ", go home and study.");
            }
        }
    }
}
