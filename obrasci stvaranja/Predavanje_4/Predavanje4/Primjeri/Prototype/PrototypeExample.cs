using System;
using Primjeri.Utilities;
using System.Collections.Generic;

namespace Primjeri.Prototype
{
    class PrototypeExample : IExample
    {
        public string Name
        {
            get
            {
                return this.ToString();
            }
        }

        public void Run()
        {
            List<Color> colors = new List<Color>(){
                new Color(0,0,0), new Color(0,147,255), new Color(15,250,140),
            };
            List<ColorPrototype> clonedColors = new List<ColorPrototype>();
            for (int i = 0; i < colors.Count; i++)
            {
                ColorPrototype prototype = colors[i];
                clonedColors.Add(prototype.Clone());
                Console.WriteLine(colors[i] + " is same as " + clonedColors[i]
                    + ":\t" + colors[i].Equals(clonedColors[i]));
            }

            ColorPalette palette = new ColorPalette();
            palette["White"] = new Color(0, 0, 0);
            ColorPrototype white = palette["White"];
            Console.WriteLine(white);
            Console.WriteLine(palette["White"]);
            Console.WriteLine(palette["White"].Equals(white));
        }
    }
}
