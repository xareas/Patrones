using System;

namespace Patrones.Decorator
{
    public abstract class DecoratorHouse : Component
    {
        private readonly Component _house;

        protected DecoratorHouse(Component house)
        {
            _house = house;
        }

        public override void MakeHouse()
        {
            _house?.MakeHouse();
        }
    }
}