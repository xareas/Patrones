namespace Patrones.Visitor
{
    public class Productor : IOriginVisitor
    {
        public string Name { get; set; }

        public Productor(string name)
        {
            this.Name = name;
        }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}