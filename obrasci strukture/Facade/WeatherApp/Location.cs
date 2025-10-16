using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.WeatherApp
{
    public class Location
    {
        public double Latitude { get; private set; }
        public double Longitude { get; private set; }
        public Location (double latitude, double longitude)
        {
            Latitude = latitude;
            Longitude = longitude;
        }
    }
}
