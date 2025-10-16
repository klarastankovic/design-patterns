using System;
using System.Collections.Generic;

namespace Primjeri.Prototype
{
    public class ColorPalette
    {
        private Dictionary<String, ColorPrototype> prototypes =
            new Dictionary<string, ColorPrototype>();

        public ColorPrototype this[String key]
        {
            get { return prototypes[key].Clone(); }
            set { prototypes.Add(key, value); }
        }
    }

}
