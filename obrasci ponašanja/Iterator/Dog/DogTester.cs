using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator.Dog
{
    public static class DogTester
    {
        public static void Test()
        {
            Shelter shelter = new Shelter();
            shelter.Add(new Dog("Lassie"));
            shelter.Add(new Dog("Odie"));
            shelter.Add(new Dog("Totto"));
            shelter.Add(new Dog("Rex"));
            IAbstractIterator iterator = shelter.CreateIterator();
            for (Dog dog = iterator.First(); iterator.IsDone == false; dog = iterator.Next())
            {
                Console.WriteLine(dog.Name);
            }
        }
    }
}
