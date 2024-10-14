public abstract class NotificationDecorator : Notification
{
    protected Notification _notification;

    public NotificationDecorator(Notification notification) : base(notification.Title, notification.Message)
    {
        _notification = notification;
    }

    public override void Display()
    {
        _notification.Display();
    }
}