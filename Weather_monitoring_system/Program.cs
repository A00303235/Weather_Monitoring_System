using System;
using Weather_monitoring_system;



namespace Weather_monitoring_system.App
{
    class Program
    {
        static void Main(string[] args)
        {
            weatherStation Weather_Station = new weatherStation();

            // Creating display objects
            IDisplay currentConditionsDisplay = Weather_Station.CreateDisplay("CurrentConditions");
            IDisplay statisticsDisplay = Weather_Station.CreateDisplay("Statistics");
            IDisplay forecastDisplay = Weather_Station.CreateDisplay("Forecast");

            // Updating weather data
            weatherData.Instance.UpdateWeatherData();

            // Displaying weather data
            currentConditionsDisplay.Display();
            statisticsDisplay.Display();
            forecastDisplay.Display();
        }
    }
}