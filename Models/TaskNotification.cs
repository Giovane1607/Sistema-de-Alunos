public class TaskNotification : Notification
{
    public TaskNotification(string title, string message) : base(title, message) { }

    public override void Display()
    {
        Console.WriteLine($"[Tarefa] {Title}: {Message}");
    }
}