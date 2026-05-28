namespace src.DesignPatterns.Behavioral.Iterator.HeadFirst.DinerMerge
{
    public class PancakeMenu : IMenu
    {

        private readonly List<MenuItem> _menuItems;

        public PancakeMenu()
        {
            _menuItems=new List<MenuItem>();
              AddItem("K&B's Pancake Breakfast", "Pancakes with scrambled eggs, and toast", true, 2.99);
            AddItem("Regular Pancake Breakfast", "Pancakes with fried eggs, sausage", false, 2.99);
            AddItem("Blueberry Pancakes", "Pancakes made with fresh blueberries", true, 3.49);
            AddItem("Waffles", "Waffles, with your choice of blueberries or strawberries", true, 3.59);
      
        }

        public void AddItem(string name, string desc, bool vegeterain, double price)
        {
            var menuItem=new MenuItem(name,desc,vegeterain,price);
           
             
             _menuItems.Add(menuItem);
    }

        public List<MenuItem> GetManuItems()
        {
            return _menuItems;
        }
        public IIterator CreateIterator()
        {
            return new PancakeMenuIterator(_menuItems);
        }
    }

   
}