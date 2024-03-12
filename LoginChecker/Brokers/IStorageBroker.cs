using LoginChecker.Models;

namespace LoginChecker.Brokers
{
    internal interface IStorageBroker
    {
        Credential[] GetAllCredentials();

        Credential AddCredential(Credential credential);
    }
}
