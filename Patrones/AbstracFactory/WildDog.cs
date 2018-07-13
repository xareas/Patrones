using System;

namespace Patrones.AbstracFactory
{
    public class WildDog : IDog
    {
        public void Speak()
        {
            Console.WriteLine("gua gua soy un perro salvaje");
        }

        public void Action()
        {
           Console.WriteLine("Acciones de perro salvaje");
        }
    }

    public class WildTiger : ITiger
    {
        public void Speak()
        {
            Console.WriteLine("Soy un Tigre salvaje");
        }

        public void Action()
        {
           Console.WriteLine("Acciones del tiger salvaje");
        }
    }

}