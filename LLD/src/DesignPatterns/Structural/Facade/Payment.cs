namespace src.DesignPatterns.Structural.Facade
{
    public class Payment
    {
        private readonly string _name;
        private readonly string _CardNumber;
        private readonly float _amount;

        public Payment(string name, string CardNumber, float amount)
        {
            _name = name;
            _CardNumber = CardNumber;
            _amount = amount;
        }

        public void Pay()
        {
            System.Console.WriteLine("Charding card with name" + _name);
        }
    }
}