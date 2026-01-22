namespace src.DesignPatterns.Behavioral.Observer.GoodObserverSolution
{
    public class DataSource:Subject
    {
         private List<int> _values = new List<int>();

        public List<int> GetValues()
        {
            return _values;
        }

        public void SetValues(List<int> values)
        {
            _values = values;
            //we inherting class that is responsible for maintining obsever and notifying so we use its method
            NotifyObservers();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}