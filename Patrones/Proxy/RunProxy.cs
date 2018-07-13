namespace Patrones.Proxy
{
    public class RunProxy
    {
        public static void Run()
        {
            var userCurrent = UserClaims.Build();
            
            var proxy = new ProxySecurity(userCurrent);
            if (proxy.FtpService())
            {
            }

        }
    }
}