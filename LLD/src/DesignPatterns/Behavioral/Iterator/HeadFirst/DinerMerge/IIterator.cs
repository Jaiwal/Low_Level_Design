namespace src.DesignPatterns.Behavioral.Iterator.HeadFirst.DinerMerge
{
    public interface IIterator
    {
        bool HasNext();
        MenuItem Next();
    }
}