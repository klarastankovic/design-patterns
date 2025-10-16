using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton.LoadBalancer
{
    public class Server
    {
        private string name;
        private int unitCapacity;
        private int currentUnitLoad;
        public string Name { get { return name; } }
        public Server (string name, int unitCapacity)
        {
            this.name = name;
            this.unitCapacity = unitCapacity;
        }
        public void TryAssignTask(ITask task)
        {
            if (GetFreeCapacity() < task.Units)
            {
                throw new CapacityFull();
            }
            this.currentUnitLoad += task.Units;
        }
        public double GetFreeCapacity()
        {
            return this.unitCapacity - this.currentUnitLoad;
        }
    }
}
