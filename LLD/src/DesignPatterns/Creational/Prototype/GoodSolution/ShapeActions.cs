

namespace src.DesignPatterns.Creational.Prototype.GoodSolution
{
    public class ShapeActions
    {
        public IShape Duplicate(IShape shape)
        {
            System.Console.WriteLine("Duplicating now");
            return shape.Duplicate();
        }
    }
}