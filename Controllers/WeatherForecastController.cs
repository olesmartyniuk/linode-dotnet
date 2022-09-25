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
    
    public async Task<string> Get()
    {
        _logger.LogInformation("Linode Test Service running at: {time}", DateTimeOffset.Now);
        _logger.LogWarning("A warning from Linode Test Service at: {time}", DateTimeOffset.Now);
        _logger.LogError("An error from Linode Test Service at: {time}", DateTimeOffset.Now);
        await Task.Delay(1000);

        return "Web API works from GitHub Actions!";
    }
}
