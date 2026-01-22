namespace src.DesignPatterns.Behavioral.Template.TeamplateMethodSolution
{
    public class Tea : Beverage
    {
        protected override void Brew()
        {
            System.Console.WriteLine("Brewing tea for 4 min");
        }
        
         protected override void AddCondiments()
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