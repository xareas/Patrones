using System;

namespace Patrones.FactoryMethod
{
    public class Dog :IAnimal
    {
        public void Speak()
        {
            Console.WriteLine("Perro dice wow wow wow");
        }

        public void Action()
        {
            Console.WriteLine("Perros prefieren ladrar");
        }
    }
}