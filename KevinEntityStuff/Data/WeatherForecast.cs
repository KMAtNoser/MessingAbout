namespace KevinEntities.Data;

public class WeatherForecast
{
    public Guid Id { get; private init; }

    public DateTime Date { get; private init; }

    public int TemperatureC { get; private init; }

    public string? Summary { get; private init; }

    private WeatherForecast()
    {
    }

    public static WeatherForecast Create(DateTime date, int temperatureC, string? summary)
    {
        return new()
        {
            Id = Guid.NewGuid(),
            Date = date,
            TemperatureC = temperatureC,
            Summary = summary
        };
    }
}
