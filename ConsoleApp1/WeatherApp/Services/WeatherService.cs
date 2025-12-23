using System.Net.Http;
using System.Net.Http.Json;
using WeatherApp.Models;


namespace WeatherApp.Services
{
    public class WeatherService
    {
        private readonly HttpClient client=new HttpClient();
        private readonly string apikey = "4c1ab92c3a79a617014742cacbf6882b";

        public async Task<WeatherApiResponse?> GetWeatherAsync(string city)
        {
            try
            {
                string url = $"https://api.openweathermap.org/data/2.5/weather?q={city}&appid={apikey}&units=metric";
                return await client.GetFromJsonAsync<WeatherApiResponse>(url);
            }
            catch (HttpRequestException)
            {
                Console.WriteLine("API request failed. Check your internet or API Key.");
                return null;

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return null;
            }
        }

    }
}