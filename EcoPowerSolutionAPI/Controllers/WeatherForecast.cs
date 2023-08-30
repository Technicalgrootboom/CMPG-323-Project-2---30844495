using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;


namespace EcoPowerSolutionAPI.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecast : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };
        private readonly ILogger<WeatherForecast> _logger;
    }

    
}