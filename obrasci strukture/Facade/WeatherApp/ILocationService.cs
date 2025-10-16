using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.WeatherApp
{
    public interface ILocationService
    {
        Location GetCoordinatesFor(String city);
    }
}
