using System;
using Weather_monitoring_system;



namespace Weather_monitoring_system.App
{
    class Program
    {
        static void Main(string[] args)
        {
            weatherStation Weather_Station = new weatherStation();

            // Create display objects
            IDisplay currentConditionsDisplay = weatherStation.CreateDisplay("CurrentConditions");
            IDisplay statisticsDisplay = weatherStation.CreateDisplay("Statistics");
            IDisplay forecastDisplay = weatherStation.CreateDisplay("Forecast");

            // Update weather data
            Weather_Data.Instance.UpdateWeatherData();

            // Display weather data
            currentConditionsDisplay.Display();
            statisticsDisplay.Display();
            forecastDisplay.Display();
        }
    }
}