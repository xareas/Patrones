using System;

namespace Patrones.Composite
{
    public class Employee : IEmployee
    {
        private string Name { get; set; }
        private string Depto { get; set; }

        public Employee(string name,string depto)
        {
            Name = name;
            Depto = depto;
        }

        public void PrintEstructura()
        {
            Console.WriteLine(this.Name);
        }
    }
}