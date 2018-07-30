using System;

namespace Patrones.Bridge
{
    public class Customer : CustomerBase
    {
        public Customer(string group) : base(group)
        {
        }

        protected override void ShowAll()
        {
            Console.WriteLine();
            Console.WriteLine("------------------------");
            base.ShowAll();
            Console.WriteLine("------------------------");
        }
    }
}