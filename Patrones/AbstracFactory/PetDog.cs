using System;

namespace Patrones.AbstracFactory
{
    public class PetDog :IDog
    {
        public void Speak()
        {
           Console.WriteLine("Gua gua soy un perro domesticado");
        }

        public void Action()
        {
           Console.WriteLine("El perro de casa no hace nada");
        }
    }

    public class PetTiger : ITiger
    {
        public void Speak()
        {
            Console.WriteLine("Miau Miau el Tiger domesticado no hace nada");
        }

        public void Action()
        {
            Console.WriteLine("El Tiger domesticado come pollo");
        }
    }

}