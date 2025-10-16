using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight.Terrain
{
    public class AdventureTerrainRepository : ITerrainRepository
    {
        Random generator = new Random();
        List<Terrain> terrains = new List<Terrain>()
        {
            new Terrain("Lake", '~', 3, true),
            new Terrain("Mountain", 'A', 2, false),
            new Terrain("Meadow", '_', 1, false)
        };
        public Terrain GetRandomTerrain()
        {
            return terrains[generator.Next(terrains.Count)];
        }
    }
}
