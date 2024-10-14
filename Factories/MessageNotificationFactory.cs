public class MessageNotificationFactory : NotificationFactory
{
    public override Notification CreateNotification(string title, string message)
    {
        return new MessageNotification(title, message);
    }
}