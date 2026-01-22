namespace src.DesignPatterns.Behavioral.Template.TeamplateMethodSolution
{
    public abstract class Beverage
    {
        public void Prepare()
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
        //protected to allow derived classes to access or
        //override them while keeping them hidden from external classes.
        protected abstract void Brew();
        //hook method
        protected virtual void AddCondiments()
        {
            
        }
        

    }
}