using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };



        private readonly ILogger<WeatherForecastController> _logger;

        private static List<WeatherForecast> ListWeatherForecasts = new List<WeatherForecast>();


        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;

            if (ListWeatherForecasts == null || ListWeatherForecasts.Any())
            {
                ListWeatherForecasts = Enumerable.Range(1, 5).Select(index => new WeatherForecast
                {
                    Date = DateTime.Now.AddDays(index),
                    TemperatureC = Random.Shared.Next(-20, 55),
                    Summary = Summaries[Random.Shared.Next(Summaries.Length)]
                })
                .ToList();
            }
        }

        [HttpGet(Name = "GetWeatherForecast")]
        [Route("Get/weatherforecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return ListWeatherForecasts;
        }

        [HttpPost]
        public IActionResult Post(WeatherForecast weatherForecast)
        {
            ListWeatherForecasts.Add(weatherForecast);

            return Ok();
        }

        [HttpDelete("{index}")]
        public IActionResult Delete(int indice)
        {
            ListWeatherForecasts.RemoveAt(indice);
            return Ok();
        }
    }
}