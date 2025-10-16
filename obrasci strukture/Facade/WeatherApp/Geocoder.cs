using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.WeatherApp
{
    public class Geocoder : ILocationService
    {
        Dictionary<String, Location> geocoder = new Dictionary<string, Location> {
            { "Osijek", new Location(15, 45) }, { "Zagreb", new Location(12,47) }
        };
        public Location GetCoordinatesFor(String city)
        {
            return geocoder[city];
        }
    }
}
