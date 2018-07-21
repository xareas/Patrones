using System;

namespace Patrones.FlyWeight
{
    public class LargeRobot : IRobot
    {
        public void Print()
        {
           Console.WriteLine("Robot mas Grande");
        }
    }
}