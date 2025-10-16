using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.WeatherApp
{
    public class Weather
    {
        public double AverageTemperature { get; private set; }
        public String Description { get; private set; }
        public Weather(double averageTemperature, string description)
        {
            AverageTemperature = averageTemperature;
            Description = description;
        }
        public override string ToString()
        {
            return this.Description + ", and is currently " + this.AverageTemperature + "°C";
        }
    }
}
