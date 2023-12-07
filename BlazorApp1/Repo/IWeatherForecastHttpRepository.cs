using KevinBlazorData;


namespace BlazorApp1.Repo;

public interface IWeatherForecastHttpRepository
{
    Task<IEnumerable<WeatherForecast>> GetForecastsByHandVersionAsync();
    Task AddForecastsByHandVersionAsync();

    Task<IEnumerable<WeatherForecast>> GetForecastsUsingWebAPIGeneratedClientAsync();

    public Task AddForecastsUsingWebAPIGeneratedClientAsync();
}

