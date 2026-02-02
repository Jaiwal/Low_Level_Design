namespace src.DesignPatterns.Creational.Prototype.BadSolution
{
    public class Circle : IShape
    {
        public int Radius { get; set; } = 5; //default for all newly created circle
        public void Draw()
        {
            System.Console.WriteLine("Drawing circle now");
        }
    }
}