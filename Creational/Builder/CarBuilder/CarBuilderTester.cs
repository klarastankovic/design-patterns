using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.CarBuilder
{
    public static class CarBuilderTester
    {
        public static void Test()
        {
            CarBuilder builder = new CarBuilder();
            builder.BuildName("Yugo_Koral_45").BuildEngine(new Engine()).BuildSeats(new Seats()).BuildWheels(new Wheels());
            Car yugo = builder.Build();
            Console.WriteLine(yugo);
        }
    }
}
