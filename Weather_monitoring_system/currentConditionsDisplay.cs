using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather_monitoring_system
{
    public class currentConditionsDisplay : IDisplay
    {
        private weatherData WeatherData;

        public currentConditionsDisplay(weatherData WeatherData)
        {
            this.WeatherData = WeatherData;
        }

        //Displaying the current weather.
        public void Display()
        {
            Console.WriteLine("Current Weather Conditions:- ");
            Console.WriteLine($"Temperature:- {WeatherData.Temperature}°C");
            Console.WriteLine($"Humidity:- {WeatherData.Humidity}%");
            Console.WriteLine($"Wind Speed:- {WeatherData.WindSpeed} km/h");
            Console.WriteLine();
        }

    }
}