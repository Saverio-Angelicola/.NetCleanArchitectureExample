namespace WeatherForecastsClean.Core
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }
        public int TemperatureC { get; set; }
        public int TemperatureF { get; set; }
        public string Summary { get; set; }

        public WeatherForecast(int temperatureC, string summary)
        {
            Date = DateTime.Now;
            TemperatureC = temperatureC;
            Summary = summary;
        }

        public WeatherForecast()
        {
            Summary = string.Empty;
        }
    }
}