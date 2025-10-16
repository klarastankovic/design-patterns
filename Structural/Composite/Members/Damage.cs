using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Members
{
    public class Damage
    {
        public int Physical { get; set; }
        public int Magical { get; set; }
        public Damage() { Physical = 0; Magical = 0; }
        public Damage(int physical, int magical)
        {
            Physical = physical;
            Magical = magical;
        }
        public static Damage operator +(Damage lhs, Damage rhs)
        {
            return new Damage(lhs.Physical + rhs.Physical, lhs.Magical + rhs.Magical);
        }
        public override string ToString()
        {
            return "PD: " + this.Physical + ", MD: " + this.Magical;
        }
    }
}
