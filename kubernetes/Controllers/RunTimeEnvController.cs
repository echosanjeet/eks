using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Globalization;

namespace kubernetes.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RunTimeEnvController : ControllerBase
    {
        private readonly ILogger<RunTimeEnvController> _logger;

        public RunTimeEnvController(ILogger<RunTimeEnvController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public string Get()
        {
            var model = new RunTimeEnv();

            var json = new JObject(                
                new JProperty("Date", model.Date),
                new JProperty("Version", model.Version),
                new JProperty("WebApiType", model.WebApiType),
                new JProperty("DbVersion", model.DbVersion),
                new JProperty("ServerName", model.MachineName),
                new JProperty("ServerOS", model.MachineOS),
                new JProperty("User", model.User));

            return json.ToString(Formatting.Indented);
        }
    }
}