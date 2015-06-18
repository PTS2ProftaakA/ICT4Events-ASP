using System;
using System.DirectoryServices.AccountManagement;

namespace ICT4Events
{
    public static class ActiveDirectory
    {
        private const string Address = "192.168.20.28:389";

        public static bool AuthenticateUser(string username, string password)
        {
            try
            {
                using (var context = new PrincipalContext(ContextType.Domain, Address))
                {
                    return context.ValidateCredentials(username, password);
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}