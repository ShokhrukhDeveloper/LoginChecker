using LoginChecker.Brokers;
using LoginChecker.Models;

namespace LoginChecker.Services.Login
{
    public class LoginService : ILoginService
    {
        private readonly IStorageBroker storageBroker;

        public LoginService()
        {
            this.storageBroker = new StorageBoker();
        }

        public bool CheckUserLogin(Credential credential)
        {
            try
            {
            foreach (Credential credentialItem in storageBroker.GetAllCredentials())
            {
                if (credential.Username == credentialItem.Username && credential.Password == credentialItem.Password)
                {
                    return true;
                }
            }
            }
            catch (Exception)
            {

                
            }


            return false;
        }
    }
}