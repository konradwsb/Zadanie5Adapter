
public class Program
{
    public static void Main(string[] args)
    {
        NewLogger newLogger = new NewLogger();
        OldLoggerInterface adapter = new NewLoggerAdapter(newLogger);

        do
        {
            Console.WriteLine("Enter the message content to log:");
            string message = Console.ReadLine();
            adapter.LogMessage(message);

            Console.WriteLine("Do you want to enter another message? (yes/no)");
        } while (Console.ReadLine().ToLower() == "yes");

    }
}



