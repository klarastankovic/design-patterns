using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.AnimalWorld
{
    public static class AnimalWorldTester
    {
        public static void Test()
        {
            ContinentFactory africa = new AfricaFactory();
            AnimalWorld world = new AnimalWorld(africa);
            world.RunFoodChain();
            ContinentFactory europe = new EuropeFactory();
            world = new AnimalWorld(europe);
            world.RunFoodChain();
        }
    }
}
