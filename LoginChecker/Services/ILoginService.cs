using LoginChecker.Models;

namespace LoginChecker.Services
{
    public interface ILoginService
    {
        bool CheckUserLogin(Credential credential);
    }
}