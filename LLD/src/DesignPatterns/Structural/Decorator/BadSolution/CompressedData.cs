namespace src.DesignPatterns.Structural.Decorator.BadSolution
{
    public class CompressedData : CloudData
    {
        public CompressedData(string url) : base(url)
        {
        }

        public override void Save(string data)
        {
            var compressed = Compress(data);
            //below ensures that the parent class handles the actual saving logic, 
            //while the CompressedData class adds its 
            //own functionality (compression)
            // before delegating the saving task to the parent.
            base.Save(compressed);
        }

        public string Compress(String data)
        {
            return data.Substring(0, 5);
            
        }
    }
}