using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primjeri.AbstractFactory
{
    public class AnimalWorld
    {
        private Herbivore herbivore;
        private Carnivore carnivore;

        // Constructor
        public AnimalWorld(ContinentFactory factory)
        {
            carnivore = factory.CreateCarnivore();
            herbivore = factory.CreateHerbivore();
        }

        public void RunFoodChain()
        {
            herbivore.Eat();
            carnivore.Eat(herbivore);
        }
    }
}
