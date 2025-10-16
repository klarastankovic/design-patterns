using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Weather
{
    public static class WeatherTester
    {
        public static void Test()
        {
            WeatherStation weatherStation = new WeatherStation(21);
            HomeThermostat nest = new HomeThermostat();
            weatherStation.AddObserver(nest);
            weatherStation.SetTemperature(34);
            weatherStation.SetTemperature(22);
            weatherStation.RemoveObserver(nest);
            weatherStation.SetTemperature(17);
        }
    }
}
