using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight.Trees
{
    public class Forest
    {
        public int Width { get; private set; }
        public int Height { get; private set; }
        private List<Tree> trees = new List<Tree>();
        public Forest(int width, int height)
        {
            Width = width;
            Height = height;
        }
        public void PlantTree(int x, int y, String name, String color, String texture)
        {
            TreeSpecies type = TreeFactory.GetTreeType(name, color, texture);
            Tree tree = new Tree(x, y, type);
            trees.Add(tree);
        }
    }
}
