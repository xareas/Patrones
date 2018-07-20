using System;

namespace Patrones.Decorator
{
    public class VentanaDecorator: DecoratorHouse
    {
        public VentanaDecorator(Component house) : base(house)
        {
        }

        public override void MakeHouse()
        {
            base.MakeHouse();
            this.AddWindow();
        }

        private void AddWindow()
        {
            Console.WriteLine("Agregamos la Ventana");
        }
    }
}