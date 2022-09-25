using Microsoft.AspNetCore.Mvc;

namespace linode_dotnet.Controllers;

[ApiController]
[Route("/")]
public class WeatherForecastController : ControllerBase
{
    private readonly ILogger<WeatherForecastController> _logger;

    public WeatherForecastController(ILogger<WeatherForecastController> logger)
    {
        _logger = logger;
    }
    
    public string Get()
    {
        return "Web API works!";
    }
}
