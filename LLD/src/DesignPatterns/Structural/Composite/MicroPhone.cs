namespace src.DesignPatterns.Structural.Composite
{
    public class MicroPhone : IItem
    {

        private float _price = 2.18f; //for now hard code
        public float GetPrice()
        {
            return _price;
        }
    }
}