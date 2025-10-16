using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton.LoadBalancer
{
    public interface ITask
    {
        string ID { get; }
        int Units { get; }
    }
}
