using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Enemy
{
    public class Terrorist : IEnemy
    {
        private int bullets;
        private double strength;
        public double HP { get; private set; }
        public Terrorist(int bullets, double strength, double hp)
        {
            this.bullets = bullets;
            this.strength = strength;
            HP = hp;
        }
        public double Hit()
        {
            return new Random().NextDouble() + strength * HP;
            //RandomGenerator.GetInstance().NextDouble(0, 1) + strength * HP;
        }
        public int Shoot()
        {
            return new Random().Next(bullets);
            //RandomGenerator.GetInstance().Next(bullets);
        }
    }
}
