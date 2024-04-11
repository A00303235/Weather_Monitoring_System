using System;

namespace Weather_monitoring_system
{
    public class weatherStation
    {
        public IDisplay CreateDisplay(string displayType)
        {
            Weather_Data weatherData = Weather_Data.Instance;

            switch (displayType)
            {
                case "CurrentConditions":
                    return new CurrentConditions_Display(weatherData);
                case "Statistics":
                    return new Statistics_Display(weatherData);
                case "Forecast":
                    return new Forecast_Display(weatherData);
                default:
                    throw new ArgumentException("Invalid display type");
            }
        }
    }
}