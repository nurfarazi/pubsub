using System.Xml;
using PubSub.Events;

namespace PubSub.Services;

public class NotificationService
{
    private UserEvents userEvents = UserEvents.GetInstance();

    public NotificationService()
    {
        Subscribe();
    }

    public void Subscribe()
    {
        userEvents.SubscribeToUserCreatedEvent(Send);
    }


    public void Send(object sender, UserEventArgs userEventArgs)
    {
        Console.WriteLine($"Notification sent to {userEventArgs.User.Name}");
    }
}