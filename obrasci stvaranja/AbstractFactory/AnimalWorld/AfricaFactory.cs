using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.AnimalWorld
{
    public class AfricaFactory : ContinentFactory
    {
        public override Herbivore CreateHerbivore()
        {
            return new Gazelle();
        }
        public override Carnivore CreateCarnivore()
        {
            return new Lion();
        }
    }
}
