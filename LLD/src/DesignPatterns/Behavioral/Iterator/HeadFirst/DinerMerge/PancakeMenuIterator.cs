namespace src.DesignPatterns.Behavioral.Iterator.HeadFirst.DinerMerge
{
    public class PancakeMenuIterator : IIterator
    {
        private readonly List<MenuItem> _items;
        private int _position;

        public PancakeMenuIterator(List<MenuItem> items)
        {
            _items=items;
        }
        public bool HasNext()
        {
           return  _position<_items.Count;
        }

        public MenuItem Next()
        {
            return _items[_position++];
        }
    }
}