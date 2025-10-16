using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight.Trees
{
    public class TreeSpecies
    {
        private String name;
        private String color;
        private String texture;
        public TreeSpecies(string name, string color, string texture)
        {
            this.name = name;
            this.color = color;
            this.texture = texture;
        }
    }
}
