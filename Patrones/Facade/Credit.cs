using System;

namespace Patrones.Facade
{
    public class Credit
    {
        public bool EsBuenCliente(Customer c)
        {
            Console.WriteLine("Es un buen cliente");
            return true;
        }
    }
}