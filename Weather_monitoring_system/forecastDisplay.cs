Console.WriteLine("Weather Forecast:");

            // Implement logic to generate and display weather forecast based on current weather data
            // Example forecast logic based on temperature
            if (weatherData.Temperature < 0)
            {
                Console.WriteLine("Freezing with a chance of snow or icy conditions");
            }
            else if (weatherData.Temperature < 10)
            {
                Console.WriteLine("Cold with a chance of rain or snow showers");
            }
            else if (weatherData.Temperature < 20)
            {
                Console.WriteLine("Cool with a chance of light rain showers");
            }
            else if (weatherData.Temperature < 30)
            {
                Console.WriteLine("Warm with a chance of sun");
            }
            else
            {
                Console.WriteLine("Hot with clear skies");
            }

            Console.WriteLine();