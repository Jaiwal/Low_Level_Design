namespace src.DesignPatterns.Behavioral.Strategy.GoodSolution
{
    public class OverlayBlur : IOverlay
    {
        public void Apply()
        {
            System.Console.WriteLine("Applying Blur overlay");
        }
    }
}