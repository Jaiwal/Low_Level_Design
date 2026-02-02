namespace src.DesignPatterns.Creational.Prototype.GoodSolution
{
    public class Rectangle : IShape
    {
        public int Width { get; set; } = 10;
        public int Height { get; set; } = 20;

        public IShape Duplicate()
        {
            var newrectangle = new Rectangle(); //clone
                newrectangle.Width = Width;
                newrectangle.Height = Height;
                 return newrectangle;
        }

        public void Draw()
        {
            System.Console.WriteLine("Drawing rectangle");
        }
    }
}