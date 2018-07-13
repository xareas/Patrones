namespace Patrones.FactoryMethod
{
    public class CatFactory:AnimalFactory
    {
        public override IAnimal CreateAnimal()
        {
            return new Cat();
        }
    }
}