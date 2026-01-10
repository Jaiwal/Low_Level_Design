public class UserService
{
     public void Register(User user)
    {
        EmailSenderr emailSenderr = new EmailSenderr();
        emailSenderr.SendEmail(user.Email, "Welcome to our platform");

    }
}