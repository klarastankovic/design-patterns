using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.WeatherApp
{
    public static class WeatherAppTester
    {
        public static void Test()
        {
            String osijek = "Osijek";
            String zagreb = "Zagreb";
            WeatherInfo info = new WeatherInfo();
            Console.WriteLine(info.GetWeather(osijek));
            Console.WriteLine(info.GetWeather(zagreb));
        }
    }
}
