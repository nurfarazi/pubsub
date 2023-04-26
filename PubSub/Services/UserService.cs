using Microsoft.AspNetCore.Mvc;
using PubSub.Entity;
using PubSub.Events;

namespace PubSub.Services;

public class UserService
{
    // List of users
    private List<User> _users = new();
    
    // Get UserEvents without creating a new instance (Singleton)
    
    private UserEvents userEvents = UserEvents.GetInstance();

    // Constructor
    public UserService()
    {
    }

    public void CreateAsync(User user)
    {
        // trigger and event using userEvent.cs
        _users.Add(new User { Name = "John Doe" });

        Console.WriteLine($"User {user.Name} created");
    }
    
    // method trigger if Created created 
    public void UserCreatedBySub(object sender, UserEventArgs e)
    {
        Console.WriteLine($"User {e.User.Name} created");
    }
    
    // Method that raises the userCreated event
    protected virtual void OnUserCreated(UserEventArgs e)
    {
        userEvents.OnUserCreated(e);
    }

    // Method to subscribe to the userCreated event
    public void SubscribeToUserCreatedEvent(UserEvents.UserCreatedEventHandler eventHandler)
    {
        userEvents.SubscribeToUserCreatedEvent(eventHandler);
    }

    // Method to unsubscribe from the userCreated event
    public void UnsubscribeFromUserCreatedEvent(UserEvents.UserCreatedEventHandler eventHandler)
    {
        userEvents.UnsubscribeFromUserCreatedEvent(eventHandler);
    }

    public IActionResult UpdateAsync(User user)
    {
        OnUserCreated(new UserEventArgs(user));
        Console.WriteLine($"User {user.Name} updated");
        return new OkResult();
    }


    public IActionResult DeleteAsync(User user)
    {
        Console.WriteLine($"User {user.Name} deleted");
        _users.Remove(user);
        return new OkResult();
    }

    public List<User> GetAsync()
    {
        Console.WriteLine($"User retrieved");
        return _users;
    }
}