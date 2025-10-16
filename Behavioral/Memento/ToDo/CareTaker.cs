using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento.ToDo
{
    public class CareTaker
    {
        public List<Memento> PreviousStates = new List<Memento>();
        public void StoreState(Memento memento) 
        { 
            PreviousStates.Add(memento);
        }
        public Memento GetLastState() 
        { 
            return PreviousStates.OrderByDescending(s => s.CreationTime).First();
        }
    }
}
