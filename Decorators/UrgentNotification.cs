public class UrgentNotification : NotificationDecorator
{
    public UrgentNotification(Notification notification) : base(notification) { }

    public override void Display()
    {
        Console.WriteLine("[URGENTE]");
        base.Display();
    }
}