namespace src.DesignPatterns.Structural.Facade
{
    public class OrderFulfillment
    {
        private Inventory _inventory;

        public OrderFulfillment(Inventory inventory)
        {
            _inventory = inventory;
        }

        public void fulfill(string name, string address, string[] items)
        {
            System.Console.WriteLine("inserting order into database");
            foreach (var item in items)
            {
                _inventory.ReduceInventory(item, 1);
            }
        }
    }
}