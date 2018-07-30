namespace Patrones.Bridge
{
    public class RunMain
    {
        public static void Run()
        {
            Customer c = new Customer("Almacen");
            c.Data = new CustomerData();
            c.Add("Juan Pedro");
            c.Show();
        }
    }
}