using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight.Terrain
{
    public class Terrain
    {
        public String Name { get; private set; }
        public char Texture { get; private set; }
        public int MovementCost { get; private set; }
        public bool IsWater { get; private set; }
        public Terrain(string name, char texture, int movementCost, bool isWater)
        {
            Name = name;
            Texture = texture;
            MovementCost = movementCost;
            IsWater = isWater;
        }
        public override string ToString()
        {
            return Texture.ToString();
        }
    }
}
