using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Weather
{
    public class WeatherStation : WeatherSubject
    {
        List<WeatherObserver> weatherObservers;
        int temperature;
        public WeatherStation(int temperature)
        {
            weatherObservers = new List<WeatherObserver>();
            this.temperature = temperature;
            Console.WriteLine("Weather station setting temperature to " + temperature);
        }
        public void AddObserver(WeatherObserver observer) { weatherObservers.Add(observer); }
        public void RemoveObserver(WeatherObserver observer) { weatherObservers.Remove(observer); }
        public void Notify()
        {
            foreach (WeatherObserver observer in weatherObservers)
            {
                observer.Update(temperature);
            }
        }
        public void SetTemperature(int newTemperature)
        {
            Console.WriteLine("Weather station setting temperature to " + newTemperature);
            temperature = newTemperature;
            Notify();
        }
    }
}
