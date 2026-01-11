namespace src.DesignPatterns.Behavioral.Strategy.GoodSolution
{
    public class CompressorWEBM : ICompressor
    {
        public void Compress()
        {
            System.Console.WriteLine("compressing using WEBM");
        }
    }
}