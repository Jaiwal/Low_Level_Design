namespace src.DesignPatterns.Creational.Prototype.BadSolution
{
    public class Rectangle : IShape
    {
        public int Width { get; set; } = 10;
        public int Height { get; set; } = 20;
        public void Draw()
        {
            System.Console.WriteLine("Drawing rectangle");
        }
    }
}