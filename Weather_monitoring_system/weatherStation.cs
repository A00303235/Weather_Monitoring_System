using System;

namespace Weather_monitoring_system
{
    public class weatherStation
    {
        public IDisplay CreateDisplay(string displayType)
        {
            weatherData WeatherData = weatherData.Instance;

            switch (displayType)
            {
                case "CurrentConditions":
                    return new currentConditionsDisplay(WeatherData);
                case "Statistics":
                    return new statisticsDisplay(WeatherData);
                case "Forecast":
                    return new forecastDisplay(WeatherData);
                default:
                    throw new ArgumentException("Invalid display type");
            }
        }
    }
}