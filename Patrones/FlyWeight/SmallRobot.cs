using System;

namespace Patrones.FlyWeight
{
    public class SmallRobot : IRobot
    {
        public void Print()
        {
            Console.WriteLine("Robot Pequeno");
        }
    }
}