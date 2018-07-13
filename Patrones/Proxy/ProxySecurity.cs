namespace Patrones.Proxy
{
    public class ProxySecurity :IClaims
    {
        
        private readonly IClaims _user;
        public ProxySecurity(IClaims user)
        {
            _user = user;
        }

        public bool NavigationWeb()
        {
           return _user.NavigationWeb();
        }

        public bool FtpService()
        {
            return _user.FtpService();
        }

        public bool RemoteLogin()
        {
            return _user.RemoteLogin();
        }
    }
}