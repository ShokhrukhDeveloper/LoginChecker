using LoginChecker.Models;
using LoginChecker.Services.Login;
using LoginChecker.Services.Storage;

namespace LoginChecker
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ILoginService loginService = new LoginService();
            ICredentialService credentialService = new CredentialService();
            bool running=true;
            do 
            {
                Console.WriteLine("Login checker");
                Console.WriteLine("1) Check login");
                Console.WriteLine("2) Create creadential login");
                string option = Console.ReadLine();
                if (option=="1")
                {
                    Console.Write("Enter login:");
                    string inputLogin= Console.ReadLine();
                    Console.Write("Enter password:");
                    string inputPassword = Console.ReadLine();
                    bool result = loginService.CheckUserLogin(new Credential() { Username = inputLogin, Password = inputPassword });
                    if (result)
                    {
                        Console.WriteLine("Successfully logged");
                    }
                    else
                    {
                        Console.WriteLine("Passwod or Username invalid");
                    }
                }

                if (option == "2")
                {
                    Console.Write("Enter login:");
                    string inputLogin = Console.ReadLine();
                    Console.Write("Enter password:");
                    string inputPassword = Console.ReadLine();
                    Credential result = credentialService.AddCredential(new Credential() { Username = inputLogin, Password = inputPassword });
                    Console.WriteLine("Successfully added");
                }
                Console.WriteLine("Do you want to continue? yes(y)/no(n)");
                string continueInput = Console.ReadLine();

                if (continueInput=="y")
                {
                    continue;
                }
                else if (continueInput=="n")
                {
                    running = false;
                }
                else
                {
                    Console.WriteLine("Invalid option");
                }
            } while (running);
            
        }
    }
}