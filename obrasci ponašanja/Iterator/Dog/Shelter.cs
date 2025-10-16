using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator.Dog
{
    public class Shelter : IAbstractCollection
    {
        private List<Dog> dogs;
        public Shelter() { dogs = new List<Dog> (); }
        public IAbstractIterator CreateIterator()
        {
            return new Iterator(this);
        }
        public int Count { get { return dogs.Count; }}
        public void Add(Dog dog) { this.dogs.Add (dog); }
        public Dog this[int index] { get { return dogs [index]; } }
    }
}
