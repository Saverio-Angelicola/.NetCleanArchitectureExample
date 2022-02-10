using FluentAssertions;
using Moq;
using System.Linq;
using WeatherForecastsClean.Application.Repositories;
using WeatherForecastsClean.Application.Services;
using WeatherForecastsClean.Core;
using Xunit;

namespace WeatherForeCastsCLean.Application.UnitTests.WeatherForecasts
{
    public class WeatherForecastServiceTests
    {
        private readonly Mock<IWeatherForecastRepository> _repo;
        private readonly WeatherForecastService _service;

        public WeatherForecastServiceTests()
        {
            _repo = new();
            _service = new(_repo.Object);
        }

        [Fact]
        public void ProcessFTemperature_WithForecasts_ReturnsForecasts()
        {
            //Arrange
            WeatherForecast[] expected = new[]
            {
                CreateRandomForecast(),
                CreateRandomForecast()
            };
            _repo.Setup(repo => repo.GetForecasts()).Returns(expected);
            //Act
            var result = _service.ProcessFTemperature();
            //Assert
            result.Should().BeEquivalentTo(expected.ToList(),options=>options.ComparingByMembers<WeatherForecast>());
        }

        [Fact]
        public void ProcessFTemperature_WithForecasts_ReturnsForecastsWithTempF()
        {
            //Arrange
            WeatherForecast[] expected = new[]
            {
                CreateRandomForecast()
            };
            _repo.Setup(repo => repo.GetForecasts()).Returns(expected);
            //Act
            var result = _service.ProcessFTemperature();
            //Assert
            result.First().TemperatureF.Should().Be(67);
        }

        private static WeatherForecast CreateRandomForecast()
        {
            return new WeatherForecast(20,"hot");
        }
    }
}
