using src.DesignPatterns.Behavioral.Strategy.BadSolution;

namespace src.DesignPatterns.Behavioral.Template.StrategyPatternSolution
{
    public class BeverageMaker
    {
        private IBeverage _beverage;


        public BeverageMaker(IBeverage beverage)
        {
            _beverage = beverage;
        }

        public void SetBeverage(IBeverage beverage)
        {
            _beverage = beverage;
        }
        //now main method to start

        public void MakeBaverage()
        {
            //common method first
            BoilWater();
            PourWaterInCup();

            //unique ones
            _beverage.Prepare();
        }
        //Below are the shared method by all beverages

        private void BoilWater()
        {
            System.Console.WriteLine("Boiling water");
        }
        private void PourWaterInCup()
        {
            System.Console.WriteLine("Pouring water");
        }


    }
}