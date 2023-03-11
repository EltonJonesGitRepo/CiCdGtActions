namespace CiCdGtActions.Services.Interfaces
{
    public interface IWeatherForecastService
    {
        IEnumerable<WeatherForecastDTO> Obter();
    }
}
