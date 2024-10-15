// /Singleton/NotificationManager.cs
public class NotificationManager 
{
    private static NotificationManager? _instance;
    private List<Notification> _notifications = new List<Notification>();
    private List<IUser> _users = new List<IUser>();  

    private NotificationManager() { }

    public static NotificationManager Instance
    {
        get
        {
            if (_instance == null)
                _instance = new NotificationManager();
            return _instance;
        }
    }

    public void AddUser(IUser user)
    {
        _users.Add(user); 
    }

    public void RemoveUser(IUser user)
    {
        _users.Remove(user);
    }

    public void AddNotification(Notification notification)
    {
        _notifications.Add(notification);
        Console.WriteLine("--------------------------------------------------");
        NotifyUsers(notification);
    }

    private void NotifyUsers(Notification notification)
    {
        var students = _users.OfType<Student>().ToList();
        var teachers = _users.OfType<Teacher>().ToList();

        // Console.WriteLine("Notificando os usuarios");
        // foreach(var user in _users)
        // {
        //     if(user.Nota < 3)
        //     {
        //         user.Update(notification);
        //     }
        // }

        if (notification is TaskNotification)
        {
            // Professores apenas enviam a notificação de TCC
            foreach (var teacher in teachers)
            {
                Console.WriteLine($"O professor {teacher.Name} enviou a notificação de TCC.");
            }

            // Agrupando notificação de TCC para alunos
            if (students.Any())
            {
                var studentNames = string.Join(", ", students.Select(s => s.Name));
                Console.WriteLine($"{studentNames} receberam a notificação sobre o TCC.");
            }
        }
        else if (notification is UrgentNotification)
        {
            // Professores enviam a notificação de urgência (por exemplo, adiamento de prova)
            foreach (var teacher in teachers)
            {
                Console.WriteLine($"O professor {teacher.Name} enviou a notificação urgente sobre a prova.");
            }

            // Agrupando notificação urgente para alunos
            if (students.Any())
            {
                var studentNames = string.Join(", ", students.Select(s => s.Name));
                Console.WriteLine($"{studentNames} receberam a notificação urgente sobre a prova.");
            }
        }
        else
        {
            // Todos os usuários recebem notificações normais
            foreach (var user in _users)
            {
                user.Update(notification);
            }
        }
        Console.WriteLine("--------------------------------------------------");
    }
}
