namespace src.DesignPatterns.Behavioral.Template.TeamplateMethodSolution
{
    public class Camomile : Beverage
    {
        protected override void Brew()
        {
            System.Console.WriteLine("Bew this camo for 9min");
        }
    }
}