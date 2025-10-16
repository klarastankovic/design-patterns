using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton.LoadBalancer
{
    public static class LoadBalancerTest
    {
        public static void Test()
        {
            int totalTasks = 30;
            Random generator = new Random();
            List<ITask> tasks = new List<ITask>();
            LoadBalancer balancer = LoadBalancer.GetInstance();
            for (int i = 0; i < totalTasks; i++)
            {
                string id = "T" + generator.Next(100);
                int units = generator.Next(20);
                tasks.Add(new WebRequestTask(id, units));
            }
            foreach(ITask task in tasks)
            {
                balancer.Balance(task);
            }
        }

    }
}
