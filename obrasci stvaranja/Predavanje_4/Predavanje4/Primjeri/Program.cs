using Primjeri.AbstractFactory;
using Primjeri.Adapter;
using Primjeri.Bridge;
using Primjeri.Builder;
using Primjeri.FactoryMethod.Document;
using Primjeri.FactoryMethod.Image;
using Primjeri.Prototype;
using Primjeri.Singleton;
using Primjeri.Utilities;
using System.Collections.Generic;

namespace Primjeri
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IExample> examples = new List<IExample>()
            {
                new AbstractFactoryExample(),
                new AdapterExample(),
                new BridgeExample(),
                new BuilderExample(),
                new DocumentExample(),
                new ImageExample(),
                new PrototypeExample(),
                new SingletonExample(),
            };

            foreach (IExample example in examples)
            {
                PrintUtilities.PrintStart(example.Name);
                example.Run();
                PrintUtilities.PrintEnd();
            }
        }
    }
}
