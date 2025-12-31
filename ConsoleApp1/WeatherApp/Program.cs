using WeatherApp.Services;
using WeatherApp.Models;
using WeatherApp.Services;

class Pro
{
    static async Task Main()
    {
        var service = new WeatherService();

        while (true)
        {
            Console.Write("Enter city name(or 'exit'):");
            string city = Console.ReadLine()!;

            if (city.ToLower() == "exit") break;

            var weatherData = await service.GetWeatherAsync(city);

            if (weatherData != null)
            {
                Console.WriteLine($"\nWeather in {weatherData.Name}:");

                if (weatherData.Weather != null && weatherData.Weather.Count > 0)
                {
                    Console.WriteLine($"Condition: {weatherData.Weather[0].Main} - {weatherData.Weather[0].Description}");
                }
                else
                {
                    Console.WriteLine("Condition: N/A");
                }

                if (weatherData.Main != null)
                {
                    Console.WriteLine($"Temperature: {weatherData.Main.Temp}°C (Feels like {weatherData.Main.Feels_like}°C)");
                    Console.WriteLine($"Humidity: {weatherData.Main.Humidity}%\n");
                }
                else
                {
                    Console.WriteLine("Temperature and humidity data not available.\n");
                }
            }
            else
            {
                Console.WriteLine("Weather data could not be retrieved. Please try again.");
            }

        }
    }
}