namespace Patrones.VisitorAnimals
{
    public interface IAnimalVisitor
    {
        void Visit(Bear bear);
        void Visit(Felino lion);
        void Visit(Snake snake);
        void Visit(Tiger tiger);
    }
}