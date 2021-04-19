using Microsoft.Extensions.Configuration;

namespace RabbitPopulationSimulation
{
    public class Statistics
    {
        public static int malelifetime;
        public static int femalelifetime;
        public static int timeofPregnancy;
        public static int loseofFertility;
        public static int percentageofRabbitsBorn;
        public static int numberofNewbornRabbits;
        public static int months;
        private readonly IConfiguration _configurationRoot;
        public Statistics(IConfiguration configurationRoot)
        {
            _configurationRoot = configurationRoot;
        }
        public void getStatisticConfiguration()
        {
            malelifetime = int.Parse(_configurationRoot.GetSection("Statistics")["malelifetime"]);
            femalelifetime = int.Parse(_configurationRoot.GetSection("Statistics")["femalelifetime"]);
            loseofFertility = int.Parse(_configurationRoot.GetSection("Statistics")["loseofFertility"]);
            timeofPregnancy = int.Parse(_configurationRoot.GetSection("Statistics")["timeofPregnancy"]);
            numberofNewbornRabbits = int.Parse(_configurationRoot.GetSection("Statistics")["numberofNewbornRabbits"]);
            percentageofRabbitsBorn = int.Parse(_configurationRoot.GetSection("Statistics")["percentageofRabbitsBorn"]);
            months = int.Parse(_configurationRoot.GetSection("Statistics")["months"]);
        }
    }
}