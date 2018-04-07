# Syku.Serilog.Config
Default configuration factory for Serilog .NET Core 2 apps

Just modify Program class in Program.cs file, so it look similar to this:

```csharp
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
```
