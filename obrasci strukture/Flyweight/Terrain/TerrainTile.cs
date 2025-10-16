using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight.Terrain
{
    public class TerrainTile
    {
        int x, y;
        Terrain type;
        public TerrainTile (int x, int y, Terrain type)
        {
            this.x = x;
            this.y = y;
            this.type = type;
        }
        public override string ToString()
        {
            return type.ToString();
        }
    }
}
