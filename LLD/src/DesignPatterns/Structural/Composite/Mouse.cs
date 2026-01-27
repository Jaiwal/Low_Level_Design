namespace src.DesignPatterns.Structural.Composite
{
    public class Mouse : IItem
    {

        private float _price = 10.98f; //for now hard code
        public float GetPrice()
        {
            return _price;
        }
    }
}