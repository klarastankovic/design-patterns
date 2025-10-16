using System;

namespace Primjeri.Builder
{
    public interface Builder
    {
        // Abstract methods, the Builders interface
        Builder BuildName(String name);
        Builder BuildEngine(Engine engine);
        Builder BuildComputer(TripComputer computer);
        Builder BuildSeats(Seats seats);
        Builder BuildWheels(Wheels wheels);
    }
}
