using CiCdGtActions.Services;

namespace CiCdGtActions.Tests
{
    public class WeatherForecastServiceTests
    {
        private readonly WeatherForecastService _service;

        public WeatherForecastServiceTests()
        {
            _service = new WeatherForecastService();
        }

        [Fact]
        public void Posso_Obter()
        {
            // act
            var dados = _service.Obter();

            // assert
            Assert.True(dados.Any());
        }
    }
}