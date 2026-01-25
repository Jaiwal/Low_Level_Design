namespace src.DesignPatterns.Behavioral.Visitor.BadSolution
{

    public class LawClient : Client
    {
        public LawClient(string name, string email) : base(name, email)
        {
        }

        public override void SendEmail()
        {
             System.Console.WriteLine("Tips to law");
        }
    }
}