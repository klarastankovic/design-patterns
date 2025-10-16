using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Weather
{
    public class HomeThermostat : WeatherObserver
    {
        bool HeatingIsOn = false;
        bool CoolingIsOn = true;
        const int HeatingThreshold = 15;
        const int CoolingThreshold = 25;
        public void Update(int temperature)
        {
            if (temperature < HeatingThreshold) { StartHeating(); }
            else if (temperature > CoolingThreshold) { StartCooling(); }
            else { StopAll(); }
        }
        private void StartHeating()
        {
            Console.WriteLine("Now heating");
            HeatingIsOn = true;
            CoolingIsOn = false;
        }
        private void StartCooling()
        {
            Console.WriteLine("Now cooling");
            HeatingIsOn = false;
            CoolingIsOn = true;
        }
        private void StopAll()
        {
            Console.WriteLine("Temperature is ok.");
            HeatingIsOn = false;
            CoolingIsOn = false;
        }
    }
}
