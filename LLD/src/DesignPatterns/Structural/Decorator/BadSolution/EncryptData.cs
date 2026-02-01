
namespace src.DesignPatterns.Structural.Decorator.BadSolution
{
    public class EncryptData : CloudData
    {
        public EncryptData(string url) : base(url)
        {
        }

        public override void Save(string data)
        {
            var encrypted = Encrypt(data);
            base.Save(data);
        }

        public string Encrypt(string data)
        {
            return "dfedz87qq3849";
        }
    }
}