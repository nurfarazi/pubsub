## simple demonstration of pub-sub using just event and delegate

You can use this example to understand the concept of event and delegate. It is a simple example of publisher and subscriber.
In this example, the publisher is a class called **`Publisher`** and the subscriber is a class called **`Subscriber`**. The publisher class
exposes an event called **`OnPublish`** and the subscriber class has a method called **`Subscribe`** that is subscribed to the publisher's
event.

When the publisher class invokes its event, all the subscribed methods are invoked.

## How to run this example?

1. Download the source code
2. Open the solution file in Visual Studio
3. Compile the solution
4. Run the application
5. run the API project for the API
6. run the console project for the console application

Try to understand the code and play with it. You can also add more subscribers to the publisher's event and see how it works.

## Attention

It is not good for production. you can use this example for learning and understanding the concept of pub sub.
I would prefer mediator pattern for production. you can find the mediator pattern example in other repository.



