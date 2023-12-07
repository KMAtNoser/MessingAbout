using Microsoft.AspNetCore.Mvc;

using KevinRepo.Data;

namespace KevinWebAPIService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly KevinRepo.IKevinRepo _kevinRepo;
        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(KevinRepo.IKevinRepo kevinRepo, ILogger<WeatherForecastController> logger)
        {
            _kevinRepo = kevinRepo;
            _logger = logger;
        }
        

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get() => _kevinRepo.GetWeatherForecast();

        [HttpPost(Name = "CreateWeatherForecast")]
        public void Post() => _kevinRepo.CreateWeatherForecast();
    }
}
