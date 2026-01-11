namespace src.DesignPatterns.Behavioral.Strategy.GoodSolution
{
    public class OverlayNone: IOverlay
    {
        public void Apply()
        {
            System.Console.WriteLine("Applying nothing");
        }
    }
}