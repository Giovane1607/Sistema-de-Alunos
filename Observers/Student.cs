public class Student : IUser
{
    public string Name { get; set; }
    public Double Nota {get; set;}

    public Student(string name, double nota)
    {
        Name = name;
        Nota = nota;
    }

    public void Update(Notification notification)
    {
       if (notification is TaskNotification)
        {

            Console.WriteLine($"{Name} recebeu a notificação sobre o TCC.");
            
        }
        else
        {
            Console.WriteLine($"{Name} recebeu a notificação:");
            notification.Display();
            Console.WriteLine();

        }
    }
}