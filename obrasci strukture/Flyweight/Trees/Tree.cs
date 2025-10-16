using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight.Trees
{
    public class Tree
    {
        private int x;
        private int y;
        private TreeSpecies type;
        public Tree(int x, int y, TreeSpecies type)
        {
            this.x = x;
            this.y = y;
            this.type = type;
        }
    }
}
