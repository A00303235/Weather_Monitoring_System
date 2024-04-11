using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather_monitoring_system
{
    public class forecastDisplay : IDisplay
    {
        private weatherData WeatherData;

        public forecastDisplay(weatherData WeatherData)
        {
            this.WeatherData = WeatherData;
            // Subscribe to events of Weatherdata 
        }
              public void Display()
        {
            Console.WriteLine("Weather Forecast:- ");

            // Logic for generating and displaying weather forecast based on current weather 
            if (WeatherData.Temperature < 0)
            {
                Console.WriteLine("Freezing with a possible snowfall or ice weather");
            }
            else if (WeatherData.Temperature < 10)
            {
                Console.WriteLine("Chilly with a potential for snow showers or rain");
            }
            else if (WeatherData.Temperature < 20)
            {
                Console.WriteLine("Cool with a possiblity of light rain showers");
            }
            else if (WeatherData.Temperature < 30)
            {
                Console.WriteLine("Warm with a chance of sun");
            }
            else
            {
                Console.WriteLine("Hot with clear skies");
            }

            Console.WriteLine();
        }
    }
}
            