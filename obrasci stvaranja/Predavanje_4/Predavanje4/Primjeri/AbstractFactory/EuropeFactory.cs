using Primjeri.AbstractFactory.ConcreteAnimals;

namespace Primjeri.AbstractFactory
{
    public class EuropeFactory : ContinentFactory
    {
        public override Herbivore CreateHerbivore() { return new GranadaHare(); }
        public override Carnivore CreateCarnivore() { return new GreyWolf(); }
    }
}
