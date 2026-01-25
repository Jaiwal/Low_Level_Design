namespace src.DesignPatterns.Behavioral.Visitor.BadSolution
{
    public class RestroClient : Client
    {
        public RestroClient(string name, string email) : base(name, email)
        {
        }

        public override void SendEmail()
        {
             System.Console.WriteLine("Tips to restro");
        }
    }
}
