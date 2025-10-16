using System;

namespace Primjeri.AbstractFactory.ConcreteAnimals
{
    public class Gazelle : Herbivore
    {
        public override void Eat() { Console.WriteLine(this.GetType().Name + ": I love eating savanna grass."); }
    }
}
