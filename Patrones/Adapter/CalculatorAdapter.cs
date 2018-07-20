using System.Net.Mime;

namespace Patrones.Adapter
{
    public class CalculatorAdapter
    {
        public double GetArea(Triangulo tri)
        {
            Rectangulo rec = new Rectangulo
            {
                longuitud = tri.baset,
                ancho = tri.alto
            };

            Calculator c = new Calculator();
            return c.GetArea(rec);
        }
    }
}