public class NewLoggerAdapter : OldLoggerInterface
{
    private NewLogger newLogger;

    public NewLoggerAdapter(NewLogger newLogger)
    {
        this.newLogger = newLogger;
    }

    public void LogMessage(string message)
    {
        newLogger.WriteLogEntry(message);
    }
}