namespace PubSub.Services;

public class NotificationService
{
    public NotificationService()
    {
    }

    public void Send(string message)
    {
        Console.WriteLine(message);
    }
}