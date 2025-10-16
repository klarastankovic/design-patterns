namespace Primjeri.Builder
{
    public class Director
    {
        public void ConstructYugo(Builder builder)
        {
            builder.BuildName("Yugo_Koral_45")
                .BuildEngine(new Engine())
                .BuildSeats(new Seats())
                .BuildWheels(new Wheels()); // fluent!
        }

        public void ConstructPorsche(Builder builder)
        {
            builder.BuildName("Porsche_911");
            builder.BuildEngine(new Engine())
                .BuildComputer(new TripComputer())
                .BuildSeats(new Seats())
                .BuildWheels(new Wheels()); // fluent!
        }
    }
}
