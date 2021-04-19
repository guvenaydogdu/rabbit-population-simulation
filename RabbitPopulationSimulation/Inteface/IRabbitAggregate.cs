namespace RabbitPopulationSimulation.Inteface
{
    public abstract class IRabbitAggregate<T> where T : class
    {
        public abstract IRabbitIterator<T> CreateIterator();
    }
}