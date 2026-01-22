namespace src.DesignPatterns.Behavioral.Observer.BadSolution
{
    public class Sheet2
    {
        private int _total;

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
    }
}