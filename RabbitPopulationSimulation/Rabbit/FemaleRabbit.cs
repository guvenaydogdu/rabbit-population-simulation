namespace RabbitPopulationSimulation.Rabbit
{
    public class FemaleRabbit : Rabbit
    {
        private int timeofPregnancy;
        private int loseofFertility;
        private bool _isPregnant;
        public FemaleRabbit()
        {
            this.lifetime = Statistics.femalelifetime;
            this.loseofFertility = Statistics.loseofFertility;
            this.timeofPregnancy = Statistics.timeofPregnancy;
            this.age = 0;
            this._isPregnant = false;
        }
        public int getTimeofPregnancy()
        {
            return timeofPregnancy;
        }
        public void setTimeofPregnancy(int timeofPregnancy)
        {
            this.timeofPregnancy = timeofPregnancy;
        }
        public int getLoseofFertility()
        {
            return loseofFertility;
        }
        public void setLoseofFertility(int loseofFertility)
        {
            this.loseofFertility = loseofFertility;
        }
        public bool isPregnant()
        {
            return _isPregnant;
        }
        public void setPregnant(bool isPregnant)
        {
            this._isPregnant = isPregnant;
        }
    }
}