namespace src.DesignPatterns.Behavioral.Template.StrategyPatternSolution
{
    public class Tea : IBeverage
    {
        public void Prepare()
        {  //below are methods specefic to this beverage, we will have common method in seperate class
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