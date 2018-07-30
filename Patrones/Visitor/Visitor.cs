namespace Patrones.Visitor
{
    public class Visitor : IVisitor

    {
        public void Visit(Productor prod)
        {
           prod.Accept(this);
        }
    }
}