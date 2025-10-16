using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Memento.Game
{
    public class MemoryCard
    {
        List<Save> Saves = new List<Save>();
        public void StoreSave(Save save)
        {
            this.Saves.Add(save);
        }
        public Save GetLastSave()
        {
            return Saves.OrderByDescending(s => s.Timestamp).First();
        }
    }
}
