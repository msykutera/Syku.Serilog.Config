using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Serilog;

namespace Syku.Serilog.Config.Example
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var isDebug = true;

            #if RELEASE
                isDebug = false;
            #endif

            Log.Logger = LoggerFactory.GetDefaultLogger(isDebug);

            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .UseSerilog()
                .Build();
    }
}