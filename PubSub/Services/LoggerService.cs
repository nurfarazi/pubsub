namespace PubSub.Services;

public class LoggerService
{
    public void Log(string message)
    {
        Console.WriteLine(message);
    }

    public void Log(string message, ConsoleColor color)
    {
        Console.ForegroundColor = color;
        Console.WriteLine(message);
        Console.ResetColor();
    }

    public void Log(string message, ConsoleColor color, ConsoleColor backgroundColor)
    {
        Console.ForegroundColor = color;
        Console.BackgroundColor = backgroundColor;
        Console.WriteLine(message);
        Console.ResetColor();
    }

    public void Log(string message, ConsoleColor color, ConsoleColor backgroundColor, int fontSize)
    {
        Console.ForegroundColor = color;
        Console.BackgroundColor = backgroundColor;
        Console.WriteLine(message);
        Console.ResetColor();
    }

    public void Log(string message, ConsoleColor color, ConsoleColor backgroundColor, int fontSize,
        ConsoleColor fontColor)
    {
        Console.ForegroundColor = fontColor;
        Console.BackgroundColor = backgroundColor;
    }
}