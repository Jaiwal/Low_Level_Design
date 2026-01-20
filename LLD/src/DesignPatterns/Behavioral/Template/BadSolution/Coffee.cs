namespace src.DesignPatterns.Behavioral.Template.BadSolution
{
    public class Coffee
    {   
        //duplicate code below and will be present as we add new beverages
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

    }
}