
namespace LoginChecker.Brokers
{
    internal interface ILoggingBroker
    {
        void LogInformation(string message);
        void LogWarning(string message);
        void LogError(Exception exception);
        void LogError(string message);
    }
}
