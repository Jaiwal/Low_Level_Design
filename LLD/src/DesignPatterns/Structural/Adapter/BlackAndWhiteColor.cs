namespace src.DesignPatterns.Structural.Adapter
{
    public class BlackAndWhiteColor : IColor
    {
        public void Apply(Video video)
        {
            System.Console.WriteLine("Appying b and w to the video");
        }
    }
}