namespace src.DesignPatterns.Behavioral.Template.StrategyPatternSolution
{
    public class Camomile : IBeverage
    {
        public void Prepare()
        {
            Brew();
           
        }
        private void Brew()
        {
            System.Console.WriteLine("Brewing camomile for 3 minutes");
        }
       
    }

}