namespace src.DesignPatterns.Behavioral.Strategy.GoodSolution
{
    public class CompressorMOV : ICompressor
    {
        public void Compress()
        {
            System.Console.WriteLine("compressing using MOV");
        }
    }
}