using API.Entity;
using API.Events;
using Bogus;

namespace API.Services;

public class UserService
{
    // list of users
    private IList<User> users = new List<User>();

    // get method for user
    public List<User> Get()
    {
        return users.ToList();
    }

    // post method for user and add to list
    public void Post()
    {
        // add user to list using faker
        var user = new Faker<User>();
        users.Add(user);

        var buttonMaster = new UserEvents(new NotificationService());

        buttonMaster.OnUserCreatedHandler += (sender, args) => { Console.WriteLine("Button pressed event handled!"); };

        buttonMaster.OnButtonPressed(string.Empty);
    }
}