using System.Collections.Generic;

namespace Patrones.VisitorAnimals
{
    public class RunMain
    {
        public static void Run()
        {
            var visita = new DoctorVisit();
            
            var animals = new List<Animal>
            {
                new Bear(),
                new Felino(),
                new Snake(),
                new Tiger()
            };
            visita.VisitAll(animals);
        }
    }
}