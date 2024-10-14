public class MessageNotification : Notification
{
    public MessageNotification(string title, string message) : base(title, message) { }

    public override void Display()
    {
        Console.WriteLine($"[Mensagem] {Title}: {Message}");
    }
}