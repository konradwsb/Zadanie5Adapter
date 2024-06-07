public class OldLogger : OldLoggerInterface
{
    public void LogMessage(string message)
    {
        Console.WriteLine("Old Logger: " + message);
    }
}