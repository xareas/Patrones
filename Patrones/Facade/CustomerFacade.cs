using System.Threading;

namespace Patrones.Facade
{
    public class CustomerFacade
    {
        public CustomerFacade()
        {
            
        }

        public bool isElegible(Customer c)
        {
            var bank = new Bank();
            var cred = new Credit();
            if (bank.TieneFondo(c,800) && cred.EsBuenCliente(c))
                return true;
            return false;
        }
    }
}