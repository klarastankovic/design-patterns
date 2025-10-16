using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Color
{
    public class Color : ColorPrototype
    {
        private int red, green, blue;
        public Color (int red, int green, int blue)
        {
            this.red = red; this.green = green; this.blue = blue;
        }
        public override ColorPrototype Clone()
        {
            return new Color(this.red, this.green, this.blue);
        }
        public override string ToString()
        {
            return "[" + red + ":" + green + ":" + blue + "]";
        }
    }
}
