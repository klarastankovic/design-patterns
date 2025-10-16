using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton.LoadBalancer
{
    public class WebRequestTask : ITask
    {
        private string id;
        private int units;
        public WebRequestTask(string id, int units)
        {
            this.id = id;
            this.units = units;
        }
        public string ID { get { return id; } }
        public int Units { get { return units; } }
    }
}
