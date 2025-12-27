public class Order
{
    // public void PlaceOrder()
    // {
    //     place order login, insert in db, decrease stock

    //     EmailSender emailSender = new EmailSender();
    //     emailSender.SendEmail("Oder has been placed");

    //     EmailSender emailSender = new EmailSender();
    //     emailSender.SendNotification("Order has been placed"); //still tight coupling

    //   }
    private readonly INotificationService notificationService;

    public Order(INotificationService notificationService)
    {
        this.notificationService = notificationService;
    }

    public void PlaceOrder()
    {
        notificationService.SendNotification("Order has been placed");
   }
}