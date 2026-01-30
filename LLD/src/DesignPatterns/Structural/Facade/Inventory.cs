namespace src.DesignPatterns.Structural.Facade
{
    public class Inventory
    {
        public bool CheckInventory(string itemid)
        {
            return true; //keeping simple
        }

        public void ReduceInventory(string itemid, int amount)
        {
            System.Console.WriteLine("Reduce inventory of " + itemid + " by " + amount);
        }
    }
}