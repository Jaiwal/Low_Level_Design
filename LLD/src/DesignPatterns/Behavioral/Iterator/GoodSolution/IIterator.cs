namespace src.DesignPatterns.Behavioral.Iterator.GoodSolution
{
    public interface IIterator<T>
    {
        void Next();

        bool HasNext();

        T Current();
    }
}