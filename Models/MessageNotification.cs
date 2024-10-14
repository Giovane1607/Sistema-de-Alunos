public abstract class Notification
{
    public string Title { get; set; }
    public string Message { get; set; }

    public Notification(string title, string message)
    {
        Title = title;
        Message = message;
    }

    public abstract void Display();
}