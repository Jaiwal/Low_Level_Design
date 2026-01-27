namespace src.DesignPatterns.Structural.Composite
{
    public class KeyBoard : IItem
    {

        private float _price = 40.98f; //for now hard code
        public float GetPrice()
        {
            return _price;
        }
    }
}