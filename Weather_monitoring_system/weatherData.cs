using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace Weather_montitoring_system
{
    public class weatherData
    {
        private static weatherData? instance;
        private Random random;
        private List<int> tempHistory;

        private weatherData()
        {
            random = new Random();
            tempHistory = new List<int>();
        }

        public static weatherData Instance
        {
            get
            {
                if (instance == null)
                    instance = new weatherData();
                return instance;
            }
        }

        // Variables to hold the data of weather (temperature, humidity, wind speed,)
        public int Temperature { get; private set; }
        public int Humidity { get; private set; }
        public int WindSpeed { get; private set; }

        // Method for updating data of weather and notify users
        public void UpdateWeatherData()
        {
            // Generating random values for all three
            Temperature = random.Next(-20, 40); // Generates random temperature between -20°C and 40°C
            Humidity = random.Next(0, 101); // Generates random humidity between 0% and 100%
            WindSpeed = random.Next(0, 101); // Generates random wind speed between 0 km/h and 100 km/h

            // Adding current temperature to history
            tempHistory.Add(Temperature);

            // Notifing observers (display objects) about the weather data change
            NotifyObservers();
        }

        // Method for retreiving temperature history
        public int[] GetempHistory()
        {
            return tempHistory.ToArray();
        }

        // Method to notify observers
        private void NotifyObservers()
        {
            // Implementation to notify observers
        }

    }
}


