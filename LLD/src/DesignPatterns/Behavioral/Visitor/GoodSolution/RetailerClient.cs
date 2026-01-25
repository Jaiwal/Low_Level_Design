namespace src.DesignPatterns.Behavioral.Visitor.GoodSolution
{
    public class RetailerClient : Client
    {
        public RetailerClient(string name, string email) : base(name, email)
        {
        }

        public override void Accept(IVisitor visitor)
        {
            visitor.VisitRetail(this);
        }
    }
}