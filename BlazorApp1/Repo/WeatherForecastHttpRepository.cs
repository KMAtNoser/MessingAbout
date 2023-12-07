using KevinBlazorData;
using System.Text.Json;

namespace BlazorApp1.Repo;

public class WeatherForecastHttpRepository : IWeatherForecastHttpRepository
{
    public class GetForecastsException : Exception
    {
        public GetForecastsException(): base("Error adding weather forecast") { }
    }

    public class AddForecastsException : Exception
    {
        public AddForecastsException() : base("Error adding weather forecast") { }
    }

    private readonly HttpClient _httpClient;
    WebAPIGeneratedClient.WebAPIGeneratedClient _webAPIGeneratedClient;
    private readonly JsonSerializerOptions _options;
    public WeatherForecastHttpRepository(HttpClient httpClient)
    {
        _httpClient = httpClient;
        _webAPIGeneratedClient = new WebAPIGeneratedClient.WebAPIGeneratedClient("https://localhost:7075/", _httpClient);
        _options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
    }
    
    public async Task<IEnumerable<WeatherForecast>> GetForecastsByHandVersionAsync()
    {
        var response = await _httpClient.GetAsync("https://localhost:7075/WeatherForecast/");
        var content = await response.Content.ReadAsStringAsync();
        if (!response.IsSuccessStatusCode)
        {
            throw new GetForecastsException();
        }
        var forecasts = JsonSerializer.Deserialize<List<WeatherForecast>>(content, _options);
        return forecasts ?? Enumerable.Empty<WeatherForecast>();
    }

    public async Task AddForecastsByHandVersionAsync()
    {
        var response = await _httpClient.PostAsync("https://localhost:7075/WeatherForecast/",null);
        if (!response.IsSuccessStatusCode)
        {
            throw new AddForecastsException ();
        }
    }

    public async Task<IEnumerable<WeatherForecast>> GetForecastsUsingWebAPIGeneratedClientAsync()
    => (await _webAPIGeneratedClient.GetWeatherForecastAsync())
            .Select(x => WeatherForecast.Create(x.Date.DateTime, x.TemperatureC, x.Summary));

    public Task AddForecastsUsingWebAPIGeneratedClientAsync() => _webAPIGeneratedClient.CreateWeatherForecastAsync();
}
