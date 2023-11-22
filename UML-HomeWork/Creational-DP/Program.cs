using System;

namespace Factory_DP;

public class User
{
    // Sms-in gedeceyi user
}

// IProduct Interface
interface INotify
{
    void SendNotification(User user);
}

// ConcreteProductA Class
class MailNotify : INotify
{
    public void SendNotification(User user)
    {
        //SMS sender
    }
}

// ConcreteProductB Class
public class SmsNotify : INotify
{
    public void SendNotification(User user)
    {
        // SMS sender
    }
}

// ProductFactory Class
class NotifyFactory
{
    public INotify CreateNotify(string notifyType)
    {
        if (notifyType == "SMS")
        {
            return new SmsNotify();
        }
        else if (notifyType == "MAIL")
        {
            return new MailNotify();
        }
        return null;
    }
}