using RabbitPopulationSimulation.Inteface;
using RabbitPopulationSimulation.Rabbit;
using System.Collections.Generic;

namespace RabbitPopulationSimulation.Concrete
{
    public class RabbitIterator<T> : IRabbitIterator<T> where T : class
    {
        private readonly List<T> _rabbits;
        private int _currentIndex = 0;
        public RabbitIterator(List<T> rabbits)
        {
            this._rabbits = rabbits;
        }
        public override T First()
        {
            _currentIndex = 0;
            return _rabbits[0];
        }
        public override T Next()
        {
            _currentIndex++;
            if (IsDone())
                return _rabbits[_currentIndex];
            else
                return null;
        }
        public override bool IsDone()
        {
            return _currentIndex < _rabbits.Count;
        }
        public override T CurrentItem()
        {
            return _rabbits[_currentIndex];
        }
        public override void Remove()
        {
            _rabbits.RemoveAt(_currentIndex);
        }
    }
}