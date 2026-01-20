
namespace src.DesignPatterns.Behavioral.Template.BadSolution
{
    public class Tea
    {
        public void MakeBaverage()
        {
            BoilWater();
            PourWaterInCup();
            Brew();
            AddCondiments();
        }
        private void BoilWater()
        {
            System.Console.WriteLine("Boiling water");
        }
        private void PourWaterInCup()
        {
            System.Console.WriteLine("Pouring water");
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