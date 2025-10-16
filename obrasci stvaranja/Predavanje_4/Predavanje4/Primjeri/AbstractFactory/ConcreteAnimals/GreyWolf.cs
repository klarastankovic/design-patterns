using System;

namespace Primjeri.AbstractFactory.ConcreteAnimals
{
    public class GreyWolf : Carnivore
    {
        public override void Eat(Herbivore h)
        {
            Console.WriteLine(this.GetType().Name + " eats " + h.GetType().Name);
        }
    }
}
