namespace src.DesignPatterns.Behavioral.Visitor.GoodSolution
{
    public class PDFExportVisitor : IVisitor
    {
        public void VisitLaw(LawClient lawClient)
        {
            System.Console.WriteLine("PDF law market");
        }

        public void VisitRestro(RestoClient restoClient)
        {
            System.Console.WriteLine("PDF restro market");
        }

        public void VisitRetail(RetailerClient retailerClient)
        {
           System.Console.WriteLine("PDF reatail market");
        }
    }
}