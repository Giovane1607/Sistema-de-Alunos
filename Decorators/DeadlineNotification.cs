public class DeadlineNotification : NotificationDecorator
{
    public string Deadline { get; set; }

    public DeadlineNotification(Notification notification, string deadline) : base(notification)
    {
        Deadline = deadline;
    }

    public override void Display()
    {
        base.Display();
        Console.WriteLine($"[Prazo: {Deadline}]");
    }
}