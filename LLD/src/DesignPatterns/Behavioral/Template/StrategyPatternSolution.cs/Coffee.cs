namespace src.DesignPatterns.Behavioral.Template.StrategyPatternSolution
{
    public class Coffee : IBeverage
    {
        public void Prepare()
        {
            Brew();
            AddCondiments();
        }
        private void Brew()
        {
            System.Console.WriteLine("Brewing water");
        }
        private void AddCondiments()
        {
            if (CustomerWantesCondiments())
            {
                System.Console.WriteLine("Adding lemon to tea");
            }
        }

        private bool CustomerWantesCondiments()
        {
            System.Console.WriteLine("Would you like lemon with your tea(y/n)");
            string input = Console.ReadLine();
            return input.ToLower() == "y";
        }
    }

}