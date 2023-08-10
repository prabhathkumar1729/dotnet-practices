namespace DependencyInjectionImplementation;
public interface ILogger
{
    void log(string message);
}

class ConsoleLogger : ILogger
{
    public void log(string message)
    {
        System.Console.WriteLine("In Console Logger: " + message);
        System.Console.WriteLine("Inserted Successfully");
    }
}

class FileLogger : ILogger
{
    public log(string message)
    {
        System.Console.WriteLine("In File Logger: " + message);
        System.Console.WriteLine("Inserted Successfully");
    }
}

class DBLogger : ILogger
{
    public void log(string message)
    {
        System.Console.WriteLine("In DB Logger: " + message);
        System.Console.WriteLine("Inserted Successfully");
    }
}

class Input
{
    ILogger IL;

    public Input(string choice)
    {
        IL = LoggerFactory.GetLoggerObj(choice);
    }
    public void PutLogMsg(string message)
    {
        IL.log(message);
    }

}

public static class LoggerFactory
{
    public static ILogger GetLoggerObj(string choice)
    {
        switch (choice)
        {
            case "1":
                return new ConsoleLogger();
                break;
            case "2":
                return new FileLogger();
                break;
            case "3":
                return new DBLogger();
                break;
            default:
                return null;
        }
    }
}
class Program
{
    public static void Main(string[] args)
    {
        Input l;
        do
        {
            System.Console.WriteLine("1) Console Logger\n2) File Logger\n3) DB Logger\nEnter choice: ");
            string choice = Console.ReadLine();
            l = new Input(choice);
            System.Console.WriteLine("Enter Log Msg");
            string msg = Console.ReadLine();
            l.PutLogMsg(msg);
        }
        while (true);
    }
}
