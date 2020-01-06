using System;
using Xunit;
using SimpleAPI.Controllers;
using Microsoft.Extensions.Logging;

namespace SimpleAPI.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {

        }

        WeatherForecastController weatherForecastController = new WeatherForecastController();
        [Fact]
        public void GetReturnsCorrectNumber()
        {
            var returnValue = weatherForecastController.GetValue();
            Assert.Equal("SreeSree", returnValue);
        }

    }
}
