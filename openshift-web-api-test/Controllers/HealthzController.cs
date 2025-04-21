using Microsoft.AspNetCore.Mvc;

namespace openshift_web_api_test.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HealthzController : Controller
    {

        private readonly ILogger<WeatherForecastController> _logger;

        public HealthzController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "Healthz")]
        public ActionResult Get()
        {
            return Ok("I'm Working");
        }
    }
}
