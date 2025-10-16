using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Enemy
{
    public class EnemyRobotAdapter : IEnemy
    {
        private Robot Robot { get; set; }
        public double HP { get { return this.Robot.BatteryCharge; } }
        public EnemyRobotAdapter(Robot robot)
        {
            Robot = robot;
        }
        public int Shoot() { return 0; }
        public double Hit()
        {
            return this.Robot.BatteryCharge > 5 ? 20 : 0;
        }
    }
}
