namespace Patrones.VisitorAnimals
{
    public class Bear : Animal
    {
        public override void Accept(IAnimalVisitor visit)
        {
           visit.Visit(this);
        }
    }
}