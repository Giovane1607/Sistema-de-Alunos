namespace Atividade;

class Program
{
    static void Main(string[] args)
    {

        var manager = NotificationManager.Instance;

        IUser student1 = new Student("João");
        IUser student2 = new Student("Maria");
        IUser student3 = new Student("Lucas");

        IUser teacher1 = new Teacher("Professor Silva");
        IUser teacher2 = new Teacher("Professor Sérgio");

        manager.AddUser(student1);
        manager.AddUser(student2);
        manager.AddUser(student3);
        manager.AddUser(teacher1);
        manager.AddUser(teacher2);

        NotificationFactory taskFactory = new TaskNotificationFactory();
        NotificationFactory messageFactory = new MessageNotificationFactory();

        var taskNotification = taskFactory.CreateNotification("Nova Tarefa", "Entregar o TCC até o final do mês.");
        var messageNotification = messageFactory.CreateNotification("Nova Mensagem", "A prova foi adiada.");


        var urgentMessage = new UrgentNotification(messageNotification);
        var deadlineTask = new DeadlineNotification(taskNotification, "30/10/2024");

        manager.AddNotification(taskNotification);         
        manager.AddNotification(urgentMessage);            
        manager.AddNotification(deadlineTask);             
    }
}
