using CiCdGtActions.Services;
using CiCdGtActions.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CiCdGtActions.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;

        private readonly IWeatherForecastService _weatherForecastService;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IWeatherForecastService weatherForecastService)
        {
            _logger = logger;
            _weatherForecastService = weatherForecastService;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecastDTO> Get()
        {
            return _weatherForecastService.Obter();
            //return Enumerable.Range(1, 5).Select(index => new WeatherForecastDTO
            //{
            //    Date = DateTime.Now.AddDays(index),
            //    TemperatureC = Random.Shared.Next(-20, 55),
            //    Summary = Constantes.Summaries[Random.Shared.Next(Constantes.Summaries.Length)]
            //})
            //.ToArray();
        }
    }
}