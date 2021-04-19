using Microsoft.Extensions.Configuration;

namespace RabbitPopulationSimulation
{
    public class RPSStartup
    {
        public static IConfigurationBuilder Builder()
        {
            return new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", true, true);
        }
    }
}