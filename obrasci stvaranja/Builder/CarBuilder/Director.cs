using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.CarBuilder
{
    public class Director
    {
        public void ConstructYugo(Builder builder)
        {
            builder.BuildName("Yugo_Koral_45").BuildEngine(new Engine())
                .BuildSeats(new Seats()).BuildWheels(new Wheels());
        }
        public void ConstructPorsche(Builder builder)
        {
            builder.BuildName("Porsche_911").BuildEngine(new Engine()).BuildComputer(new TripComputer())
                .BuildSeats(new Seats()).BuildWheels(new Wheels());
        }
    }
}
