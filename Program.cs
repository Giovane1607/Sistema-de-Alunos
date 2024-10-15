namespace Atividade;

class Program
{
  

    static void Main(string[] args)
    {
        var manager = NotificationManager.Instance;

        while (true)
        {
            Console.WriteLine("Adicione o nome do aluno ou digite sair para sair:");
            string studentName = Console.ReadLine();
            
            if (studentName?.ToLower() == "sair")
            break;

            Console.WriteLine("Adicione a nota do aluno" );
            double studentNota = Convert.ToDouble(Console.ReadLine());
            
            

            IUser student = new Student(studentName, studentNota);
            manager.AddUser(student);
        }

        IUser teacher1 = new Teacher("Professor Diego");
        IUser teacher2 = new Teacher("Professor Antonello");
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

        Console.WriteLine("Pressione qualquer tecla para sair...");
        Console.ReadKey();
    }
}
