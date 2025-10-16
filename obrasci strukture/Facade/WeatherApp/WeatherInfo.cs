using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.WeatherApp
{
    public class WeatherInfo
    {
        IWeatherService weatherService = new OpenWeather();
        ILocationService locationService = new Geocoder();
        public Weather GetWeather(String city)
        {
            Location location = this.locationService.GetCoordinatesFor(city);
            Weather weather = this.weatherService.GetWeatherFor(location.Latitude, location.Longitude);
            return weather;
        }
    }
}
