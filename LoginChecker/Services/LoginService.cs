using LoginChecker.Brokers;
using LoginChecker.Models;

namespace LoginChecker.Services
{
    public class LoginService
    {
        private readonly IStorageBroker storageBroker;

        public LoginService()
        {
            this.storageBroker = new StorageBoker();
        }

        public bool CheckUserLogin(Credential credential)
        {
            foreach (Credential credentialItem in storageBroker.GetAllCredentials())
            {
                if (credential.UserName == credentialItem.UserName && credential.Password == credentialItem.Password)
                {
                    return true;
                }
            }

            return false;
        }
    }
}