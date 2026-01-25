namespace src.DesignPatterns.Behavioral.Visitor.BadSolution
{
    public abstract class Client
    {
        protected string _name;

        protected string _email;

        public Client(string name, string email)
        {
            _name = name;
            _name = email;
        }

        public abstract void SendEmail();
    }
}