using WeatherForecastsClean.Application.Repositories;
using WeatherForecastsClean.Core;

namespace WeatherForecastsClean.Application.Services
{
    public class WeatherForecastService : IWeatherForecastService
    {
        private readonly IWeatherForecastRepository _repo;

        public WeatherForecastService(IWeatherForecastRepository repo)
        {
            _repo = repo;
        }

        public List<WeatherForecast> ProcessFTemperature()
        {
            WeatherForecast[] forecasts = _repo.GetForecasts();
            List<WeatherForecast> processed = new();

            foreach(var f in forecasts)
            {
                f.TemperatureF = 32 + (int)(f.TemperatureC /0.5556);
                processed.Add(f);
            }
            return processed;
        }
    }
}
