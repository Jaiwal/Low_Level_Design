using src.DesignPatterns.Creational.AbstractFactory.GoodSolution.Package;

namespace src.DesignPatterns.Creational.AbstractFactory.GoodSolution
{ //user class of the package
    public class UserSettingsForm
    {

        public void Render(IUIComponentFactory uIComponentFactory)
        {
            uIComponentFactory.CreateButton().Render();
            uIComponentFactory.CreateCheckbox().Render();
            
           //now we are talking to the factory
        }
    }
}