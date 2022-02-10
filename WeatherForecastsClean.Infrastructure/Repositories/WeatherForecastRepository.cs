using WeatherForecastsClean.Application.Repositories;
using WeatherForecastsClean.Core;

namespace WeatherForecastsClean.Infrastructure.Repositories
{
    public class WeatherForecastRepository : IWeatherForecastRepository
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing","Bracing","Chilly","Cool","Mild","Warm","Balmy","Hot","Sweltering","Scorcing"
        };

        public WeatherForecast[] GetForecasts()
        {
            Random rng = new();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20,55),
                Summary = Summaries[rng.Next(Summaries.Length)]

            })
            .ToArray();
        }
    }
}