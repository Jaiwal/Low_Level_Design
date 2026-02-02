namespace src.DesignPatterns.Creational.Prototype.GoodSolution
{
    public class Circle : IShape
    {
        public int Radius { get; set; } = 5; //default for all newly created circle

        public IShape Duplicate()
        {
            var newcirle = new Circle(); //the clone
            newcirle.Radius = Radius;
            return newcirle;
        }

        public void Draw()
        {
            System.Console.WriteLine("Drawing circle");
        }
    }
}