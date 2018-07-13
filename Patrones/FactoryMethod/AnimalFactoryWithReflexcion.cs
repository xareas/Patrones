using System;
using System.Numerics;
using System.Reflection;

namespace Patrones.FactoryMethod
{
    public abstract class AnimalFactoryReflex
    {
        public abstract IAnimal GetAnimal(string Type);
    }

    public class AnimalFactoryWithReflexcion : AnimalFactoryReflex
    {
        public static IAnimal GetAnimal(Type type) 
        {
            //tambien lo pude obtener asi type.GetConstructor(Type.EmptyTypes);
            return (IAnimal) Activator.CreateInstance(type);
        }

        public override IAnimal GetAnimal(string type)
        {
            var animal = Type.GetType(type);
            return GetAnimal(animal);
        }


        
    }
}