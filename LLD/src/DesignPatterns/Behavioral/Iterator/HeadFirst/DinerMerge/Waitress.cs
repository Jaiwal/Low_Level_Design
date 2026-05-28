namespace src.DesignPatterns.Behavioral.Iterator.HeadFirst.DinerMerge
{
    public class Waitress
    {
        private readonly IMenu _pancakeMenu;
        private readonly IMenu _dinerMenu;

        public Waitress(IMenu pancakeMenu,IMenu dinerMenu)
        {
            _pancakeMenu=pancakeMenu;
            _dinerMenu=dinerMenu;
        }

        public void PrintMenu()
        {
            IIterator pancakeIterator=_pancakeMenu.CreateIterator();
            IIterator dinerIterator=_dinerMenu.CreateIterator();

            
            Console.WriteLine("MENU\n----\nBREAKFAST");
            PrintMenu(pancakeIterator);
            Console.WriteLine("\nLUNCH");
            PrintMenu(dinerIterator);
          

        }

        private void PrintMenu(IIterator iterator)
        {
            while (iterator.HasNext())
            {
                MenuItem menuItem = iterator.Next();
                Console.WriteLine($"{menuItem.Name}");
                Console.WriteLine(menuItem.Description);
            }
        }


         public void PrintVegetarianMenu()
        {
            PrintVegetarianMenu(_pancakeMenu.CreateIterator());
            PrintVegetarianMenu(_dinerMenu.CreateIterator());
        }

        private void PrintVegetarianMenu(IIterator iterator)
        {
           
            while (iterator.HasNext())
            {
                MenuItem menuItem = iterator.Next();
                if (menuItem.IsVegetarian)
                {
                    Console.WriteLine($"{menuItem.Name} \t\t {menuItem.Price.ToString()}");
                    Console.WriteLine("\t" + menuItem.Description);
                }
            }
        }
    }
}