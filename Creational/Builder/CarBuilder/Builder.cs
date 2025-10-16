using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.CarBuilder
{
    public interface Builder
    {
        Builder BuildName(String name);
        Builder BuildEngine(Engine engine);
        Builder BuildComputer(TripComputer computer);
        Builder BuildSeats(Seats seats);
        Builder BuildWheels(Wheels wheels);
    }
}
