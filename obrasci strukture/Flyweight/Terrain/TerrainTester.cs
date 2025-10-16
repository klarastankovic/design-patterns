using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight.Terrain
{
    public static class TerrainTester
    {
        public static void Test()
        {
            ITerrainRepository repo = new AdventureTerrainRepository();
            World world = World.Generate(10, 15, repo);
            Console.WriteLine(world);
        }
    }
}
