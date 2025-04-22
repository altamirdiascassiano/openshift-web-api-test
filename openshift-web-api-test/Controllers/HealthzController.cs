using Microsoft.AspNetCore.Mvc;
using openshift_web_api_test.Models;
using System.Net.NetworkInformation;

namespace openshift_web_api_test.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HealthzController : Controller
    {
        private readonly ILogger<WeatherForecastController> _logger;
        private readonly HealthStatus _health;
        private readonly HealthStatus _status;


        public HealthzController(ILogger<WeatherForecastController> logger, HealthStatus status)
        {
            _logger = logger;
            _status = status;
        }

        [HttpGet(Name = "Healthz")]
        public ActionResult Get()
        {
            return _status.IsHealthy ? Ok($"Healthy {_status.IsHealthy}") :  StatusCode(500);
        }

        [HttpGet("toggle-health")]        
        public ActionResult ToggleHealth()
        {
            _status.ToggleHealth();
            return Ok($"Toggled to {_status.IsHealthy}");
        }
    }
}
