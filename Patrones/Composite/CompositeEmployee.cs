using System;
using System.Collections;
using System.Collections.Generic;

namespace Patrones.Composite
{
    public class CompositeEmployee : IEmployee
    {
        private string Name { get; set; }
        private string Depto { get; set; }
        private IList<IEmployee> Controls { get; set; }

        public CompositeEmployee(string name,string depto)
        {
            this.Name = name;
            this.Depto = depto;
            this.Controls = new List<IEmployee>();
        }

        public void AddEmployee(IEmployee employee)
        {
            this.Controls.Add(employee);
        }

        public void RemoveEmployee(IEmployee employee)
        {
            this.Controls.Remove(employee);
        }

        public void PrintEstructura()
        {
            Console.WriteLine(this.Name);
            foreach (IEmployee employee in Controls)
            {
                employee.PrintEstructura();
            }
        }
        
        
    }
}