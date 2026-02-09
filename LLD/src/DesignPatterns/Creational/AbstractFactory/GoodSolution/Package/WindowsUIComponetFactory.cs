namespace src.DesignPatterns.Creational.AbstractFactory.GoodSolution.Package
{
    public class WindowsUICompnentFactory : IUIComponentFactory
    {
        public IButton CreateButton()
        {
            return new WindowsButton();
        }

        public ICheckbox CreateCheckbox()
        {
            return new WindowsCheckbox();
        }
    }
}