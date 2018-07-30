namespace Patrones.VisitorAnimals
{
    public class Tiger : Animal
    {
        public override void Accept(IAnimalVisitor visit)
        {
           visit.Visit(this);
        }
    }
}