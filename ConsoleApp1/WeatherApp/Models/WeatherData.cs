namespace WeatherApp.Models
{
    public class WeatherInfo
    {
        public string Main { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
    }

    public class MainInfo
    {
        public double Temp { get; set; }
        public double Feels_like { get; set; }
        public int Humidity { get; set; }
    }

    public class WeatherApiResponse
    {
        public List<WeatherInfo> Weather { get; set; } = new List<WeatherInfo>();
        public MainInfo Main { get; set; } = new MainInfo();
        public string Name { get; set; } = string.Empty;
    }
}
