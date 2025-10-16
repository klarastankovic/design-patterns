using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton.LoadBalancer
{
    public class LoadBalancer
    {
        List<Server> availableServers;
        private static LoadBalancer instance;
        private LoadBalancer()
        {
            availableServers = new List<Server>()
            {
                new Server("Blade1", 100), new Server("Blade2", 150), new Server("Blade3", 130)
            };
        }
        public static LoadBalancer GetInstance()
        {
            if (instance == null)
            {
                instance = new LoadBalancer();
            }
            return instance;
        }
        public void AddServer(Server server)
        {
            this.availableServers.Add(server);
        }
        public void Balance(ITask task)
        {
            double maxFreeCapacity = this.availableServers.Max(s => s.GetFreeCapacity());
            Server freeServer = this.availableServers.First(s => s.GetFreeCapacity() == maxFreeCapacity);
            freeServer.TryAssignTask(task);
            // Try to do this using a logger:
            Console.WriteLine("Task " + task.ID + " assigned to " + freeServer.Name);
        }
    }
}
