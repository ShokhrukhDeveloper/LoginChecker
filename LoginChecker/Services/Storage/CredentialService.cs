using LoginChecker.Brokers;
using LoginChecker.Models;

namespace LoginChecker.Services.Storage
{
    public class CredentialService : ICredentialService
    {
        private readonly IStorageBroker storageBroker;

        public CredentialService()
        {
            storageBroker = new StorageBoker();
        }

        public Credential AddCredential(Credential credential)
        {
            try
            {
            return credential is null
                            ? CreateAndLogInvalidCredential()
                            : ValidateAndAddCredential(credential);
            }
            catch (Exception)
            {

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