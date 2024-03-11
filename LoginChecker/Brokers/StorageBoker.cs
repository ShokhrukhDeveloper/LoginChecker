using LoginChecker.Models;

namespace LoginChecker.Brokers
{
    internal class StorageBoker : IStorageBroker
    {
        private static Credential[] credentials =
        {
            new Credential{UserName="shox", Password="12345" },
            new Credential { UserName = "shox1", Password = "1233345" }
        };

        public Credential[] GetAllCredentials() => credentials;
    }
}
