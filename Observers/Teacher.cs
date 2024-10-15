public class Teacher : IUser
{
    public string Name { get; set; }

    public double Nota => throw new NotImplementedException();

    public Teacher(string name)
    {
        Name = name;
    }

    public void Update(Notification notification)
    {
        if(notification is TaskNotification)
        {
            Console.WriteLine($"O professor {Name} enviou a notificação de TCC.");
        }
    }
}