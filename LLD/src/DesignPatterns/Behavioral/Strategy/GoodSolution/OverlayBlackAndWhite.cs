namespace src.DesignPatterns.Behavioral.Strategy.GoodSolution
{
    public class OverlayBlackAndWhite : IOverlay
    {
        public void Apply()
        {
            System.Console.WriteLine("Applying B and w overlay");
        }
    }
}