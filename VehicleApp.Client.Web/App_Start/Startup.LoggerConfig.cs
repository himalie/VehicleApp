using Serilog;

namespace VehicleApp.Client.Web
{
    public partial class Startup
    {
        public ILogger ConfigureLogging()
        {
            var logger = new LoggerConfiguration()
                .ReadFrom.AppSettings()
                .CreateLogger();

            Log.Logger = logger;
            return logger;
        }
    }
}