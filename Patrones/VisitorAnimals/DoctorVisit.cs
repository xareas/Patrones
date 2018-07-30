using System;
using System.Collections.Generic;

namespace Patrones.VisitorAnimals
{
    public class DoctorVisit : IAnimalVisitor
    {
        public void VisitAll(IEnumerable<Animal> animals)
        {
            foreach (Animal animal in animals)
               animal.Accept(this);
        }
        
        public void Visit(Bear bear)
        {
          Console.WriteLine("Visitando al oso");
        }

        public void Visit(Felino lion)
        {
            Console.WriteLine("Visitando al leon");
        }

        public void Visit(Snake snake)
        {
            Console.WriteLine("Visitando ala serpiente");
        }

        public void Visit(Tiger tiger)
        {
            Console.WriteLine("Visitando al tigre");
        }
    }
}