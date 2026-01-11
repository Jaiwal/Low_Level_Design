namespace src.DesignPatterns.Behavioral.Strategy.GoodSolution
{
    public class CompressorMP4 : ICompressor
    {
        public void Compress()
        {
            System.Console.WriteLine("compressing using MP4");
        }
    }
}