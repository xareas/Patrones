namespace Patrones.Visitor
{
    public interface IOriginVisitor
    {
        void Accept(IVisitor visitor);}
}