using AzureAssesment.Controllers;
using AzureAssesment;
using Microsoft.Extensions.Logging;
using Moq;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            var logger = new Mock<ILogger<WeatherForecastController>>();
            var controller = new WeatherForecastController(logger.Object);

            // Act
            var result = controller.Get();

            // Assert
            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(result, typeof(IEnumerable<WeatherForecast>));

            var forecasts = result as IEnumerable<WeatherForecast>;
            Assert.AreEqual(5, forecasts.Count());
        }
    }
}