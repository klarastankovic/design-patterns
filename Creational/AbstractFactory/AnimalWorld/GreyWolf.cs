using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.AnimalWorld
{
    public class GreyWolf : Carnivore
    {
        public override void Eat(Herbivore herbivore)
        {
            Console.WriteLine(this.GetType().Name + " eats " + herbivore.GetType().Name);
        }
    }
}
