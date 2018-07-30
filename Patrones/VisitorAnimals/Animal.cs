namespace Patrones.VisitorAnimals
{
    public abstract class Animal
    {
        public abstract void Accept(IAnimalVisitor visit);
    }
}