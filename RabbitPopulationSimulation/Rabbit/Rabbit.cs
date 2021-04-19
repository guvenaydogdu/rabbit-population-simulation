namespace RabbitPopulationSimulation.Rabbit
{
    public abstract class Rabbit
    {
		public int lifetime;
		public int age;
		public int getAge()
		{
			return age;
		}
		public void setAge(int age)
		{
			this.age = age;
		}
		public int getLifetime()
		{
			return lifetime;
		}
		public void setLifetime(int lifetime)
		{
			this.lifetime = lifetime;
		}
	}
}