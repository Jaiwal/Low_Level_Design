namespace src.DesignPatterns.Structural.Adapter
{
    public class MidnightBlueColor : IColor
    {
        public void Apply(Video video)
        {
            System.Console.WriteLine("Appying bueee to the video");
        }
    }
}