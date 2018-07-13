namespace Patrones.Proxy
{
    public  class UserClaims : IClaims
    {

        public static UserClaims Build()
        {
            return new UserClaims();
        }

        private UserClaims()
        {
        }

        public bool NavigationWeb()
        {
            return true;
        }

        public bool FtpService()
        {
            return true;
        }

        public bool RemoteLogin()
        {
            return true;
        }
    }
}