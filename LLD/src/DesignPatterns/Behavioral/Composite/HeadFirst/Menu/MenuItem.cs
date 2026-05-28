namespace src.DesignPatterns.Behavioral.Composite.HeadFirst.Menu
{
    //this the leaf node, it will have no other part, this is the smallest possible piece
    public class MenuItem : MenuComponent
    {
        private readonly string _name;
        private readonly string _description;
        private readonly bool _isVegeterian;
        private readonly decimal _price;

        public MenuItem(string name, string desc, bool veg, decimal price)
        {
            _name = name;
            _description = desc;
            _isVegeterian = veg;
            _price = price;
        }

        public override string Name => _name;
        public override string Description => _description;
        public override bool IsVegeterian => _isVegeterian;
        public override decimal Price => _price;
    }
}