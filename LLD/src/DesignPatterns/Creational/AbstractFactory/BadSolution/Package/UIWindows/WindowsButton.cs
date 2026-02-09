namespace src.DesignPatterns.Creational.AbstractFactory.BadSolution.Package
{
    public class WindowsButton : IButton
    {
        public void Render()
        {
            System.Console.WriteLine("Windows button: Prapanch here");
        }
    }
}