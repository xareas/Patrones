namespace Patrones.Adapter
{
    public class Calculator
    {
        public double GetArea(Rectangulo rec)
        {
            return rec.ancho * rec.longuitud;
        }
    }
}