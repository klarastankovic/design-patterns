using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento.Project
{
    public class Memento
    {
        public String TeamLead { get; }
        public int BugCount { get; }
        public int Cost { get; }
        public Memento(String teamLead, int bugCount, int cost)
        {
            TeamLead = teamLead;
            BugCount = bugCount;
            Cost = cost;
        }
    }
}
