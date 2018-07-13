using System;
using System.ComponentModel.DataAnnotations;

namespace Patrones.FactoryMethod
{
    public class RunMain
    {
        public static void Run()
        {
            AnimalFactory factory= new CatFactory();
            IAnimal gato =  factory.CreateAnimal();
            gato.Speak();
            gato.Action();
            
            AnimalFactory factory2 = new DogFactory();
            IAnimal dog = factory2.CreateAnimal();
            dog.Speak();
            dog.Action();
           
            AnimalFactoryWithReflexcion reflex = new AnimalFactoryWithReflexcion();
            Console.WriteLine("AHORRANDOSE LOS FACTORY INDIVIDUALES");
            var tipo = AnimalFactoryWithReflexcion.GetAnimal(typeof(Dog));
            tipo.Speak();
            
            var strTipo = typeof(Cat).FullName;
            var factoryReflex = new AnimalFactoryWithReflexcion();
            var tipo2 = factoryReflex.GetAnimal(strTipo);
            tipo2.Speak();
        }
    }
}