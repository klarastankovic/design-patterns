using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Color
{
    public static class ColorTester
    {
        public static void Test()
        {
            List<Color> colors = new List<Color>()
            {
                new Color(0,0,0), new Color(0,147,255), new Color(15,250,140) 
            };
            List<ColorPrototype> clonedColors = new List<ColorPrototype>();
            for (int i = 0; i < colors.Count; i++)
            {
                ColorPrototype prototype = colors[i];
                clonedColors.Add(prototype.Clone());
                Console.WriteLine(colors[i] + " is same as " + clonedColors[i]
                    + ":\t" + colors[i].Equals(clonedColors[i]));
            }
        }
    }
}
