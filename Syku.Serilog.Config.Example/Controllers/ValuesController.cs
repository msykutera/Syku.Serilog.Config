using Microsoft.AspNetCore.Mvc;
using Serilog;
using System.Collections.Generic;

namespace Syku.Serilog.Config.Example.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        [HttpGet]
        public IEnumerable<string> Get()
        {
            Log.Information("This message shouldn't be logged in Release configuration");
            Log.Fatal("Test log critical message");
            return new string[] { "value1", "value2" };
        }
    }
}
