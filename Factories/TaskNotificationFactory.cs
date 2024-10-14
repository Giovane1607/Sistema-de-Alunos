public class TaskNotificationFactory : NotificationFactory
{
    public override Notification CreateNotification(string title, string message)
    {
        return new TaskNotification(title, message);
    }
}