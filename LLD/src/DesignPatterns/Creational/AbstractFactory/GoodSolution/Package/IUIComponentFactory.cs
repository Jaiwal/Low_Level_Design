namespace src.DesignPatterns.Creational.AbstractFactory.GoodSolution.Package
{
    public interface IUIComponentFactory
    {
        IButton CreateButton();
        ICheckbox CreateCheckbox();
    }
}