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

        Console.WriteLine("Notificando os usuários...");
        foreach (var user in _users)
        {
            user.Update(notification);
        }
        Console.WriteLine("--------------------------------------------------");
    }
}