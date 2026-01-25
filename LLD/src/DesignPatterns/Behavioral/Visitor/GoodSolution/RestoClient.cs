namespace src.DesignPatterns.Behavioral.Visitor.GoodSolution
{
    public class RestoClient : Client
    {
        public RestoClient(string name, string email) : base(name, email)
        {
        }

        public override void Accept(IVisitor visitor)
        {
            visitor.VisitRestro(this);
        }
    }
}
