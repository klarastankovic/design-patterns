using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight.Trees
{
    public static class TreesTester
    {
        public static void Test()
        {
            const int TREE_COUNT = 1000000;
            Random generator = new Random();
            Forest amazon = new Forest(400, 400);
            for (int i = 0; i < TREE_COUNT; i++)
            {
                int x = generator.Next(0, amazon.Width);
                int y = generator.Next(0, amazon.Height);
                amazon.PlantTree(x, y, "Willow", "Green", "Willow_texture");
                amazon.PlantTree(x, y, "Birch", "White", "Birch_texture");
            }
        }
    }
}
