namespace Patrones.VisitorAnimals
{
    public class Snake : Animal
    {
        public override void Accept(IAnimalVisitor visit)
        {
            visit.Visit(this);
        }
    }
}