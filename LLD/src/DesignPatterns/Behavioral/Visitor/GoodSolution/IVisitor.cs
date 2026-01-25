
namespace src.DesignPatterns.Behavioral.Visitor.GoodSolution
{
    public interface IVisitor
    {
        void VisitRetail(RetailerClient retailerClient);

        void VisitLaw(LawClient visitorCleint);

        void VisitRestro(RestoClient visitorResto);
    }
}