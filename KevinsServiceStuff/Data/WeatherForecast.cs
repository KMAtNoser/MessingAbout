namespace KevinRepo.Data;

public record WeatherForecast(DateTime Date, int TemperatureC, string? Summary)
{
    public static explicit operator WeatherForecast(KevinEntities.Data.WeatherForecast x)
    {
        return new(x.Date, x.TemperatureC, x.Summary);
    }
}
