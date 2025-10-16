using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.AnimalWorld
{
    public class EuropeFactory : ContinentFactory
    {
        public override Herbivore CreateHerbivore()
        {
            return new GranadaHare();
        }
        public override Carnivore CreateCarnivore()
        {
            return new GreyWolf();
        }
    }
}
