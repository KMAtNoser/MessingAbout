using BlazorApp1.Repo;
using KevinBlazorData;
using Microsoft.AspNetCore.Components;

namespace BlazorApp1.Components.Pages
{
    public partial class Weather
    {
        private IEnumerable<WeatherForecast>? _forecasts;

        [Inject]
        public IWeatherForecastHttpRepository? WeatherForecastRepo { get; set; }

        protected override Task OnInitializedAsync()
        {
            return UpdateForecasts();
        }

        private async Task UpdateForecasts()
        {
            _forecasts = await WeatherForecastRepo!.GetForecastsUsingWebAPIGeneratedClientAsync();
        }

        private async Task AddWeatherForecast()
        {
            await WeatherForecastRepo!.AddForecastsUsingWebAPIGeneratedClientAsync();
            await UpdateForecasts();
        }
    }
}
