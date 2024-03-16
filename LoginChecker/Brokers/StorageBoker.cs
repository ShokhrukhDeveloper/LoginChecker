using LoginChecker.Models;

namespace LoginChecker.Brokers
{
    public class StorageBoker : IStorageBroker
    {
        private const string FilePath = "Assets/Credentials.txt";

        public StorageBoker()
        {
            EnsureFileExists();
        }

        private static Credential[] credentials =
        {
            new Credential{Username="shox", Password="12345" },
            new Credential { Username = "shox1", Password = "1233345" }
        };

        public Credential[] GetAllCredentials() => credentials; 
        
        public Credential AddCredential(Credential credential)
        {
            string credentialLine = $"{credential.Username}*{credential.Password}\n";
            File.AppendAllText(FilePath,credentialLine);

            return credential;
        }

        private void EnsureFileExists()
        {
            bool fileExists = File.Exists(FilePath);

            if (fileExists is false)
            {
                File.Create(FilePath).Close();
            }
        }
    }
}
