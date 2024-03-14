using LoginChecker.Brokers;
using LoginChecker.Models;

namespace LoginChecker.Services.Login
{
    public class LoginService : ILoginService
    {
        private readonly IStorageBroker storageBroker;
        private readonly ILoggingBroker loggingBroker;

        public LoginService()
        {
            this.storageBroker = new StorageBoker();
            this.loggingBroker = new LoggingBroker();
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
            catch (Exception exception)
            {

                this.loggingBroker.LogError($"Error occured at {nameof(CheckUserLogin)} plaese contact developer"); 
                this.loggingBroker.LogError(exception); 
            }


            return false;
        }
    }
}