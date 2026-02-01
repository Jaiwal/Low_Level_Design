namespace src.DesignPatterns.Structural.Decorator.BadSolution
{
    public class CompressedAndEncryptedData : CloudData
    {
        public CompressedAndEncryptedData(string url) : base(url)
        {
        }

        public override void Save(string data)
        {
            var compressed = new CompressedData(_url).Compress(data);
            var encryptedandcompressed = new EncryptData(_url).Encrypt(compressed);
            base.Save(encryptedandcompressed);
        }
    }
}