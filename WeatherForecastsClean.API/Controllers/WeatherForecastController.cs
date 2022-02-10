using Microsoft.AspNetCore.Mvc;
using WeatherForecastsClean.Application.Services;

namespace WeatherForecastsClean.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {

        private readonly IWeatherForecastService _service;

        public WeatherForecastController(IWeatherForecastService service)
        {
            _service = service;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IActionResult Get()
        {
            List<Core.WeatherForecast> result = _service.ProcessFTemperature();
            return Ok(result);
        }
    }
}