public class EmailSender:INotificationService
{
    // public void SendEmail(string message)
    // {
    //     //email sending logic

    //     System.Console.WriteLine($"Sending email:{ message}");
    // }

    public void SendNotification(string message)
    {
        //email sending logic

        System.Console.WriteLine($"Sending email:{ message}");
    }
}