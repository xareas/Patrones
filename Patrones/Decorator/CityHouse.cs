using System;

namespace Patrones.Decorator
{
    public class CityHouse :Component
    {
        public override void MakeHouse()
        {
           Console.WriteLine("Soy una Casa de Ciudad");
        }
    }
}