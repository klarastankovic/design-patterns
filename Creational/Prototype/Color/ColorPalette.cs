using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Color
{
    public class ColorPalette
    {
        public Dictionary<String, ColorPrototype> prototypes = 
            new Dictionary<String, ColorPrototype>();
        public ColorPrototype this[String key]
        {
            get { return prototypes[key].Clone(); }
            set { prototypes.Add(key, value); }
        }
    }
}
