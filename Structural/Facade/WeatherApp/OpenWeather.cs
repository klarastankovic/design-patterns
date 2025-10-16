using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.WeatherApp
{
    public class OpenWeather : IWeatherService
    {
        private Weather weather = new Weather(4.5, "Cold");
        public Weather GetWeatherFor(double latitude, double longitude)
        {
            return weather;
        }
    }
}
