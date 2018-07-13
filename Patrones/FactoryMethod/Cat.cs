using System;

namespace Patrones.FactoryMethod
{
    public class Cat :IAnimal
    {
        public void Speak()
        {
            Console.WriteLine("Gato dice miau miau miau");
        }

        public void Action()
        {
            Console.WriteLine("Los gatos prefieren la leche");
        }
    }
}