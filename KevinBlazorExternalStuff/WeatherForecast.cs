namespace KevinBlazorData
{
    public class WeatherForecast
    {
        //public WeatherForecast()
        //{
        //    Date = DateTime.Now;
        //    TemperatureC = 0;
        //    Summary = string.Empty;
        //}

        private WeatherForecast(DateTime date, int temperatureC, string? summary)
        {
            Date = date;
            TemperatureC = temperatureC;
            Summary = summary;
        }

        public DateTime Date { get; set; }
        public int TemperatureC { get; set; }
        public string? Summary { get; set; }
        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public static WeatherForecast Create(DateTime date, int temperatureC, string? summary)
        {
            return new(date, temperatureC, summary);
        }
    }

    // Example extension method
    public static class WeatherForecastExt
    {
        public static WeatherForecast? GetFirstChilly(this IEnumerable<WeatherForecast> array)
        {
            return array.FirstOrDefault(x => x.Summary != null && x!.Summary == "Chilly");
        }
    }
}
