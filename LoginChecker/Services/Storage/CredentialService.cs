using LoginChecker.Brokers;
using LoginChecker.Models;

namespace LoginChecker.Services.Storage
{
    public class CredentialService : ICredentialService
    {
        private readonly IStorageBroker storageBroker;
        partial readonly ILoggingBroker loggingBroker;

        public CredentialService()
        {
            this.storageBroker = new StorageBoker();
            this.loggingBroker = new LoggingBroker();
        }

        public Credential AddCredential(Credential credential)
        {
            try
            {
            return credential is null
                            ? CreateAndLogInvalidCredential()
                            : ValidateAndAddCredential(credential);
            }
            catch (Exception exception)
            {
                this.loggingBroker.LogError($"Error occured at {nameof(AddCredential)} plaese contact developer");
                this.loggingBroker.LogError(exception);
                return CreateAndLogInvalidCredential();
            }
            
        }

        private Credential CreateAndLogInvalidCredential()
        {

            Console.WriteLine("Contact is invalid");
            return new Credential();
        }

        private Credential ValidateAndAddCredential(Credential credential)
        {
            if ( String.IsNullOrWhiteSpace(credential.Username)
                || String.IsNullOrWhiteSpace(credential.Password))
            {
                Console.WriteLine("Contact details missing.");

                return new Credential();
            }
            else
            {
                return this.storageBroker.AddCredential(credential);
            }
        }
    }
}