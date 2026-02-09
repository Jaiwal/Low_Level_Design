namespace src.DesignPatterns.Creational.AbstractFactory.GoodSolution.Package
{
    public class WindowsButton : IButton
    {
        public void Render()
        {
            System.Console.WriteLine("Windows button: Prapanch here");
        }
    }
}