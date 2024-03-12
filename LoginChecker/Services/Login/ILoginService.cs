using LoginChecker.Models;

namespace LoginChecker.Services.Login
{
    public interface ILoginService
    {
        bool CheckUserLogin(Credential credential);
    }
}