using System;

namespace Patrones.Facade
{
    public class Bank
    {
        public bool TieneFondo(Customer c, double monto)
        {
            Console.WriteLine("Si tiene fondos");
            return true;
        }
    }
}