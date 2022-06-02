using System;
using Xunit;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using SimpleAPI.Controllers;

namespace SimpleAPI.TEST
{
    public class UnitTest1
    {
        static ILogger<WeatherForecastController> _logger;

        WeatherForecastController controller = new WeatherForecastController(_logger);

        [Fact]
        public void GetReturnsWeather()
        {
            var returnValue = controller.Get();
            // Assert.IsType<WeatherForecast>(returnValue);
        } 
    }
}
