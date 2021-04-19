using RabbitPopulationSimulation.Rabbit;

namespace RabbitPopulationSimulation.Inteface
{
    public abstract class IRabbitIterator<T> where T : class
    {
        public abstract T First();
        public abstract T Next();
        public abstract bool IsDone();
        public abstract T CurrentItem();
        public abstract void Remove();
    }
}