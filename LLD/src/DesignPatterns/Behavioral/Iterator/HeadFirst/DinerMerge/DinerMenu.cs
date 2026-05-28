namespace src.DesignPatterns.Behavioral.Iterator.HeadFirst.DinerMerge
{
    public class DinerMenu : IMenu
    {
        private const int Max_items=6;
        private int _noofitems;
        private readonly MenuItem[] _menuItems;

        public DinerMenu()
        {
            _menuItems=new MenuItem[Max_items];
            AddItem("K&B's Pancake Breakfast", "Pancakes with scrambled eggs, and toast", true, 2.99);
    AddItem("Regular Pancake Breakfast", "Pancakes with fried eggs, sausage", false, 2.99);
    AddItem("Blueberry Pancakes", "Pancakes made with fresh blueberries", true, 3.49);
    AddItem("Waffles", "Waffles, with your choice of blueberries or strawberries", true, 3.59);

        }

        public void AddItem(string name, string desc, bool vegeterain, double price)
        {
            var menuItem=new MenuItem(name,desc,vegeterain,price);
            if (_noofitems >= Max_items)
            {
                Console.WriteLine("Sorry, menu is full, cant add more items");
            }
            else
            {
                _menuItems[_noofitems++]=menuItem;
            }
        }

        public MenuItem[] GetManuItems()
        {
            return _menuItems;
        }
        public IIterator CreateIterator()
        {
            return new DinerMenuIterator(_menuItems);
        }
    }

   
}