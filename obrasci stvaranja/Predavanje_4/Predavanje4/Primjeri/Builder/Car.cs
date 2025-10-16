using System;

namespace Primjeri.Builder
{
    public class Car
    {
        private String Name { get; set; }
        private Engine CarEngine { get; set; }
        private TripComputer CarComputer { get; set; }
        private Seats CarSeats { get; set; }
        private Wheels CarWheels { get; set; }

        public Car(String name, Engine engine, TripComputer computer, Seats seats, Wheels wheels)
        {
            this.Name = name;
            this.CarEngine = engine;
            this.CarComputer = computer;
            this.CarSeats = seats;
            this.CarWheels = wheels;
        }

        public override string ToString()
        {
            return Name + ": \n\tEngine: " + CarEngine + "\n\tComputer: " + CarComputer
                + "\n\tSeats" + CarSeats + "\n\tWheels" + CarWheels;
        }
    }
}
