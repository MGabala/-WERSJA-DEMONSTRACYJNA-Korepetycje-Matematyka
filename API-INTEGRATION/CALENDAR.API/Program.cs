
namespace CALENDAR_INTEGRATION // Note: actual namespace depends on the project name.
{
    internal class APIIntegration
    {
        static async Task Main(string[] args)
        {
            using IHost host = CreateHostBuilder(args).Build();
            var serviceProvider = host.Services;
            try
            {
                var log = host.Services.GetRequiredService<ILogger<APIIntegration>>();
                log.LogInformation("Host created");
                await serviceProvider.GetService<IService>().Run();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
            await host.RunAsync();
        }

        private static IHostBuilder CreateHostBuilder(string[] args)
        {
            return Host.CreateDefaultBuilder(args).ConfigureServices(
                (serviceCollection) => ConfigureServices(serviceCollection));
        }

        private static void ConfigureServices(IServiceCollection serviceCollection)
        {
            serviceCollection.AddLogging(config => config.AddDebug().AddConsole());
            serviceCollection.AddScoped<IService, CRUDService>();
        }
    }
}