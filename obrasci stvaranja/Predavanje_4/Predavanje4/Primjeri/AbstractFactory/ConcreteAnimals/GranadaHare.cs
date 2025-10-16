using System;

namespace Primjeri.AbstractFactory.ConcreteAnimals
{
    public class GranadaHare : Herbivore
    {
        public override void Eat() { Console.WriteLine(this.GetType().Name + ": I love eating your flowers."); }
    }
}
