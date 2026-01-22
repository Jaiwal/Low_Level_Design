


namespace src.DesignPatterns.Behavioral.Observer.GoodObserverSolution
{
    public class BarChart : IObserver
    {
        //we need a way to get value from datasource 
        private DataSource _dataSource;

        public BarChart(DataSource dataSource)
        {
            _dataSource = dataSource;
        }
        public void Update()
        {
            System.Console.WriteLine("rendering bar charrt");
        }

    }
}