using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento.Project
{
    public class SoftwareProject
    {
        public String TeamLead { get; set; }
        public int BugCount { get; set; }
        public int Cost { get; set; }
        public Memento Store()
        {
            return new Memento(TeamLead, BugCount, Cost);
        }
        public void Restore(Memento memento)
        {
            this.TeamLead = memento.TeamLead;
            this.BugCount = memento.BugCount;
            this.Cost = memento.Cost;
        }
        public override string ToString()
        {
            return TeamLead + ", " + BugCount + ", " + Cost;
        }
    }
}
