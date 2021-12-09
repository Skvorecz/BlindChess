using System;
using Microsoft.Extensions.DependencyInjection;

namespace BlindChessConsole
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var serviceProvider = ConfigureServices();
            serviceProvider.GetRequiredService<Application>().Run();
        }

        private static IServiceProvider ConfigureServices()
        {
            var services = new ServiceCollection();
            services.AddSingleton<Application>();
            return services.BuildServiceProvider();
        }
    }
}