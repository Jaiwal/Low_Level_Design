public class SmsSender : INotificationService
{
	public void SendNotification(string message)
	{
		// Implementation for sending SMS
		Console.WriteLine($"Sending SMS: {message}");
	}
}