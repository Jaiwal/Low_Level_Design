namespace src.DesignPatterns.Behavioral.Observer.BadSolution
{
    public class DateSource
    {
        private List<int> _values = new List<int>();

        private List<Object> _dependents = new List<object>();

        public List<int> GetValues()
        {
            return _values;
        }

        public void SetValues(List<int> values)
        {
            _values = values;
            //now need to update all dependents/observers that values has updated

            foreach (var dependent in _dependents)
            {
                if (dependent is Sheet2)
                {
                    (dependent as Sheet2).CalculatTotal(_values);
                }
                if (dependent is BarChart)
                {
                    (dependent as BarChart).Render(_values);
                }
            }
        }

        public void AddDepended(Object dependent)
        {
            _dependents.Add(dependent);
        }

        public void RemoveDependent(Object dependent)
        {
            _dependents.Remove(dependent);
        }

    }
}