using System;

namespace Patrones.Decorator
{
    public class PisoDecorator:DecoratorHouse
    {
        
        public PisoDecorator(Component house) : base(house)
        {
        }

        public override void MakeHouse()
        {
            base.MakeHouse();
            this.AddPiso();
        }

        private void AddPiso()
        {
            Console.WriteLine("Agregamo el Piso");
        }
    }
}