namespace src.DesignPatterns.Behavioral.Visitor.BadSolution
{
    public class RetailerClient : Client
    {
        public RetailerClient(string name, string email) : base(name, email)
        {
        }

        public override void SendEmail()
        {
            System.Console.WriteLine("Tips to retailer");
        }
    }
}