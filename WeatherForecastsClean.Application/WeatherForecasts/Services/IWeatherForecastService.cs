using WeatherForecastsClean.Core;

namespace WeatherForecastsClean.Application.Services
{
    public interface IWeatherForecastService
    {
        List<WeatherForecast> ProcessFTemperature();
    }
}
