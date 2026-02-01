namespace src.DesignPatterns.Structural.Decorator.GoodSolution
{
    public class CompressionDataDecorator : DataDecorator
    {
        public CompressionDataDecorator(IData data) : base(data)
        {
        }

        public override void Save(string data)
        {
            System.Console.WriteLine("Compressing data");
            var compressed = Compress(data);
            //now using compostion
            //base.Save(compressed);
            base._data.Save(compressed);
        }

        public string Compress(String data)
        {
            return data.Substring(0, 5);
            
        }
    }
}