namespace src.DesignPatterns.Creational.AbstractFactory.GoodSolution.Package
{
    public class MacUICompnentFactory : IUIComponentFactory
    {
        public IButton CreateButton()
        {
            return new MacButton();
        }

        public ICheckbox CreateCheckbox()
        {
            return new MacCheckbox();
        }
    }
}