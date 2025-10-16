using System;
using Primjeri.Utilities;

namespace Primjeri.Builder
{
    class BuilderExample : IExample
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
            CarBuilder builder = new CarBuilder();
            builder.BuildName("Yugo_Koral_45");
            builder.BuildEngine(new Engine());
            builder.BuildSeats(new Seats()).BuildWheels(new Wheels()); // fluent!
            Car yugo = builder.Build();
            Console.WriteLine(yugo);

            CarBuilder carbuilder = new CarBuilder();
            Director director = new Director();
            director.ConstructPorsche(carbuilder);
            Car porsche = carbuilder.Build();
            Console.WriteLine(porsche);
        }
    }
}
