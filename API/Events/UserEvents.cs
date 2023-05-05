using API.Services;

namespace API.Events;

public class UserEvents
{
    private readonly NotificationService notificationService;
    public event EventHandler? OnUserCreatedHandler;

    public UserEvents(NotificationService notificationService)
    {
        this.notificationService = notificationService;
        Console.WriteLine("ButtonMaster created.");
        // delegate event handler to notification service send method
        OnUserCreatedHandler += (sender, args) => { notificationService.Send(); };
    }
    
    public void OnButtonPressed(string keyPressed)
    {
        Console.WriteLine($"Button pressed: {keyPressed}");

        OnUserCreatedHandler?.Invoke(this, EventArgs.Empty);
    }
}