using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Enemy
{
    public class Robot
    {
        public double BatteryCharge { get; private set; }
        public Robot() { BatteryCharge = 100; }
        public void Work(int hours) { this.BatteryCharge -= 10 * hours; }
    }
}
