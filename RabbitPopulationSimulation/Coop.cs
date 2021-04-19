using RabbitPopulationSimulation.Enum;
using RabbitPopulationSimulation.Rabbit;
using System.Collections.Generic;

namespace RabbitPopulationSimulation
{
    public class Coop
    {
        public List<MaleRabbit> maleRabbits = new List<MaleRabbit>();
        public List<FemaleRabbit> femaleRabbits = new List<FemaleRabbit>();
        private int percentageofRabbitsBorn;
        private int numberofNewbornRabbits;
        public Coop()
        {
            this.numberofNewbornRabbits = Statistics.numberofNewbornRabbits;
            this.percentageofRabbitsBorn = Statistics.percentageofRabbitsBorn;
        }
        public Rabbit.Rabbit getGenderRabbits(Gender gender, bool isPregnant = false)
        {
            Rabbit.Rabbit rabbit = null;
            if (gender.Equals(Gender.MALE))
            {
                maleRabbits.Add(new MaleRabbit());
            }
            else if (gender.Equals(Gender.FEMALE))
            {
                femaleRabbits.Add(new FemaleRabbit());
            }
            return rabbit;
        }
        public int getPercentageofRabbitsBorn()
        {
            return percentageofRabbitsBorn;
        }
        public void setPercentageofRabbitsBorn(int percentageofRabbitsBorn)
        {
            this.percentageofRabbitsBorn = percentageofRabbitsBorn;
        }
        public int getNumberofNewbornRabbits()
        {
            return numberofNewbornRabbits;
        }
        public void setNumberofNewbornRabbits(int numberofNewbornRabbits)
        {
            this.numberofNewbornRabbits = numberofNewbornRabbits;
        }
    }
}