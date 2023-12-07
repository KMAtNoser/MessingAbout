using KevinEntities;
using KevinRepo.Data;

namespace KevinRepo;

public interface IKevinRepo
{
    IEnumerable<WeatherForecast> GetWeatherForecast();

    void CreateWeatherForecast();
}

public class KevinRepo: IKevinRepo
{
    public KevinTestDBContext DBContext { private get; set; }

    public KevinRepo(KevinTestDBContext dbContext)
    {
        DBContext = dbContext;
    }


    public IEnumerable<WeatherForecast> GetWeatherForecast() => DBContext.WeatherForecast.Select(x => (WeatherForecast)x);

    public void CreateWeatherForecast()
    {
       
        var summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        var weatherForecast = KevinEntities.Data.WeatherForecast.Create(
            date: DateTime.Now.AddDays(Random.Shared.Next(-7, +7)),
            temperatureC: Random.Shared.Next(-20, 55),
            summary: summaries[Random.Shared.Next(summaries.Length)]);
        DBContext.WeatherForecast.Add(weatherForecast);

        DBContext.SaveChanges();
    }
}

