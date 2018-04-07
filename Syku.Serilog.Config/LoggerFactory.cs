using Serilog;
using Serilog.Core;
using Serilog.Events;

namespace Syku.Serilog.Config
{
    public static class LoggerFactory
    {
        public static Logger GetDefaultLogger(bool isDebug)
        {
            if (isDebug)
            {
                return new LoggerConfiguration()
                                .MinimumLevel.Debug()
                                .MinimumLevel.Override("Microsoft", LogEventLevel.Information)
                                .Enrich.FromLogContext()
                                .WriteTo.Console()
                                .CreateLogger();
            }

            return new LoggerConfiguration()
                            .MinimumLevel.Error()
                            .WriteTo.RollingFile("logs/log.txt", retainedFileCountLimit: 7)
                            .WriteTo.LiterateConsole()
                            .CreateLogger();
        }
    }
}