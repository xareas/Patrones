namespace Patrones.Decorator
{
    public class RunMain
    {
        public static void Run()
        {
            var casaBase = new CityHouse();
           
            DecoratorHouse casaPiso = new PisoDecorator(casaBase);
            DecoratorHouse casaVentana = new VentanaDecorator(casaPiso);
           

           casaVentana.MakeHouse();

        }
    }
}