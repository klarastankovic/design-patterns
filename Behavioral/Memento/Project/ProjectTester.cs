using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento.Project
{
    public static class ProjectTester
    {
        public static void Test()
        {
            SoftwareProject project = new SoftwareProject();
            project.TeamLead = "Dennis M. Ritche";
            project.BugCount = 170;
            ProjectManagementSystem management = new ProjectManagementSystem();
            management.Memento = project.Store();
            Console.WriteLine(project);
            project.TeamLead = "Bill Jobs";
            project.BugCount = 169;
            project.Cost = 10000;
            Console.WriteLine(project);
            project.Restore(management.Memento);
            Console.WriteLine(project);
        }
    }
}
