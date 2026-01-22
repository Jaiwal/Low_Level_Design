namespace src.DesignPatterns.Behavioral.Observer.GoodObserverSolution
{
    public class Sheet2 : IObserver
    {

        private int _total;

        private DataSource _dataSource;

        public Sheet2(DataSource dataSource)
        {
            _dataSource = dataSource;
        }

        public int GetTotal()
        {
            return _total;
        }
        public int CalculatTotal(List<int> values)
        {
            var sum = 0;
            foreach (var value in values)
            {
                sum += value;
            }
            System.Console.WriteLine("Total " + sum);
            return sum;
        }
        public void Update()
        {
            _total = CalculatTotal(_dataSource.GetValues());
        }
    }
}