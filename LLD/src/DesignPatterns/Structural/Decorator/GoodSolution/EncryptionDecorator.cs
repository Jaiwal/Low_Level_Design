namespace src.DesignPatterns.Structural.Decorator.GoodSolution
{
    public class EncryptionDecorator : DataDecorator
    {
        public EncryptionDecorator(IData data) : base(data)
        {
        }

        public override void Save(string data)
        {
          var encrypted = Encrypt(data);
            base._data.Save(data);
        }

        public string Encrypt(string data)
        {
            return "dfedz87qq3849";
        }
    }
}