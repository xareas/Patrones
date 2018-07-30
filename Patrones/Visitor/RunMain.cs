namespace Patrones.Visitor
{
    public class RunMain
    {
        public static void Run()
        {
            IVisitor visitor = new Visitor();
            Productor productor = new Productor("Carmelo");
            productor.Accept(visitor);
            
        }
    }
}