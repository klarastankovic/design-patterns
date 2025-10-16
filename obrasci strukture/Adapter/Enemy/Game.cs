using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Enemy
{
    public static class Game
    {
        public static void Play()
        {
            Terrorist osama = new Terrorist(200, 50, 0.70);
            Terrorist marc = new Terrorist(100, 70, 1.00);
            marc.Shoot();
            Robot unit223 = new Robot();
            unit223.Work(5);
            List<IEnemy> enemies = new List<IEnemy>();
            enemies.Add(marc);
            enemies.Add(osama);
            enemies.Add(new EnemyRobotAdapter(unit223));
            foreach (IEnemy enemy in enemies)
            {
                Console.WriteLine(enemy.ToString() + " " + enemy.Hit());
            }
        }
    }
}
