using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.AnimalWorld
{
    public class Gazelle : Herbivore
    {
        public override void Eat()
        {
            Console.WriteLine(this.GetType().Name + ": I love eating savanna grass.");
        }
    }
}
