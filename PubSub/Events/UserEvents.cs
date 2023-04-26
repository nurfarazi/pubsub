using PubSub.Entity;

namespace PubSub.Events
{
    public class UserEvents
    {
        // Create an instance also check for instance so that it does not duplicate (singleton)
        private static UserEvents _instance;

        public static UserEvents GetInstance()
        {
            if (_instance == null)
            {
                _instance = new UserEvents();
            }

            return _instance;
        }

        // Define the delegate type for the userCreated event.
        public delegate void UserCreatedEventHandler(object sender, UserEventArgs e);

        // Define the userCreated event.
        public event UserCreatedEventHandler UserCreated;

        // Define a method that raises the userCreated event.
        protected internal virtual void OnUserCreated(UserEventArgs e)
        {
            UserCreated?.Invoke(this, e);
        }

        // Method to subscribe to the userCreated event
        public void SubscribeToUserCreatedEvent(UserCreatedEventHandler eventHandler)
        {
            UserCreated += eventHandler;
        }

        // Method to unsubscribe from the userCreated event
        public void UnsubscribeFromUserCreatedEvent(UserCreatedEventHandler eventHandler)
        {
            UserCreated -= eventHandler;
        }
    }
    public class UserEventArgs : EventArgs
    {
        public User User { get; set; }

        public UserEventArgs(User user)
        {
            User = user;
        }
    }
}
