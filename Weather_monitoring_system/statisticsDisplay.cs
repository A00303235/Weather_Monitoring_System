using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather_monitoring_system
{
    public class statisticsDisplay : IDisplay
    {
        private weatherData weatherData;

        public statisticsDisplay(weatherData weatherData)
        {
            this.weatherData = weatherData;
            // Subscribe to events of Weatherdata 
        }

        public void Display()
        {
            int[] temperatures = weatherData.GetempHistory();

            if (temperatures.Length == 0)
            {
                Console.WriteLine("No data of weather  available for statistics");
                return;
            }

            // Calculate statistics
            int totalTemperature = 0;
            int maxTemperature = int.MinValue;
            int minTemperature = int.MaxValue;

            foreach (int temperature in temperatures)
            {
                totalTemperature += temperature;
                maxTemperature = Math.Max(maxTemperature, temperature);
                minTemperature = Math.Min(minTemperature, temperature);
            }

            double averageTemperature = (double)totalTemperature / temperatures.Length;

            // Display statistics
            Console.WriteLine("Weather Statistics:");
            Console.WriteLine($"Average Temperature: {averageTemperature:F1}°C");
            Console.WriteLine($"Max Temperature: {maxTemperature}°C");
            Console.WriteLine($"Min Temperature: {minTemperature}°C");
            Console.WriteLine();
        }
    }
}