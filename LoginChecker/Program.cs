using LoginChecker.Models;
using LoginChecker.Services.Storage;

namespace LoginChecker
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Credential credential = new Credential(){Username = "Rifat", Password="Salombek1900"};
            ICredentialService credentialService = new CredentialService(); 

            credentialService.AddCredential(credential);
        }
    }
}