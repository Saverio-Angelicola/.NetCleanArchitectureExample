using WeatherForecastsClean.Core;

namespace WeatherForecastsClean.Application.Repositories
{
    public interface IWeatherForecastRepository
    {
        WeatherForecast[] GetForecasts(); 
    }
}
