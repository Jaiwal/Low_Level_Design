public class User
{
    public string Username { get; set; }
    public string Email { get; set; }

    // public void Register()
    // {
    //     //register user logic..fetching from db by email, if exist redirect to login stuff

    //     //send email, this right here violates S since it contains user data but it also sending email, this can change for more than 1 reason
    //     EmailSenderr emailSenderr = new EmailSenderr();
    //     emailSenderr.SendEmail(Email, "Welcome to our platform");

    //    //should create another class called userservice instead 
    // }
    
}