using Microsoft.AspNetCore.Mvc;
using PubSub.Entity;
using PubSub.Events;

namespace PubSub.Services;

public class UserService
{
    // List of users
    private List<User> _users = new();
    
    // Instance of the UserEvents class
    private UserEvents userEvent = new UserEvents();

    // Constructor
    public UserService()
    {
    }

    public void CreateAsync(User user)
    {
        // trigger and event using userEvent.cs
        // and add users to list
        _users.Add(new User { Name = "John Doe" });

        Console.WriteLine($"User {user.Name} created");
        OnUserCreated(new UserEventArgs(user));
    }
    
    // Method that raises the userCreated event
    protected virtual void OnUserCreated(UserEventArgs e)
    {
        userEvent.OnUserCreated(e);
    }

    // Method to subscribe to the userCreated event
    public void SubscribeToUserCreatedEvent(UserEvents.UserCreatedEventHandler eventHandler)
    {
        userEvent.SubscribeToUserCreatedEvent(eventHandler);
    }

    // Method to unsubscribe from the userCreated event
    public void UnsubscribeFromUserCreatedEvent(UserEvents.UserCreatedEventHandler eventHandler)
    {
        userEvent.UnsubscribeFromUserCreatedEvent(eventHandler);
    }

    public IActionResult UpdateAsync(User user)
    {
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