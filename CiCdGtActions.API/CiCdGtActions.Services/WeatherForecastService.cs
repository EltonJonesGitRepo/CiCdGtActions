using CiCdGtActions.Services.Interfaces;

namespace CiCdGtActions.Services
{
    public class WeatherForecastService: IWeatherForecastService
    {
        public IEnumerable<WeatherForecastDTO> Obter()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecastDTO
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Constantes.Summaries[Random.Shared.Next(Constantes.Summaries.Length)]
            })
            .ToArray();
        }
    }
}