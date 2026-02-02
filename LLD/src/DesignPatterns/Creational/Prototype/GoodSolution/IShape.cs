namespace src.DesignPatterns.Creational.Prototype.GoodSolution
{
    public interface IShape
    {
        void Draw();
        IShape Duplicate();
    }
}