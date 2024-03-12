using LoginChecker.Models;

namespace LoginChecker.Services.Storage
{
    public interface ICredentialService
    {
        Credential AddCredential(Credential credential);
    }
}