namespace src.DesignPatterns.Behavioral.Visitor.GoodSolution
{
    public class EmailVisitor : IVisitor
    {
        public void VisitLaw(LawClient lawClient)
        {
            System.Console.WriteLine("sending law market tis "+lawClient.GetEmail());
        }

        public void VisitRestro(RestoClient restoClient)
        {
             System.Console.WriteLine("sending restro market tis "+restoClient.GetEmail());
        }

        public void VisitRetail(RetailerClient retailerClient)
        {
             System.Console.WriteLine("sending retail market tis "+retailerClient.GetEmail());
        }
    }
}