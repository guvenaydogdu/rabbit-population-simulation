namespace RabbitPopulationSimulation.Rabbit
{
    public class MaleRabbit : Rabbit
    {
		public MaleRabbit()
		{
			this.lifetime = Statistics.malelifetime;
			this.age = 0;
		}
	}
}