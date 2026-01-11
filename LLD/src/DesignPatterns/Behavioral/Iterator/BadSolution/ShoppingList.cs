namespace src.DesignPatterns.Behavioral.BadSolution.Iterator
{
    public class ShoppingList
    {
        private List<string> _list = new List<string>();
        //can cause issue say we change data type of list
        //private string[] _list = new string[40];
        public void Push(string itemName)
        {
            _list.Add(itemName);
        }

        public string Pop()
        {
            var last = _list.Last();
            _list.Remove(last);
            return last;
        }

        public List<string> GetList()
        {
            return _list;
        }

    }
}
