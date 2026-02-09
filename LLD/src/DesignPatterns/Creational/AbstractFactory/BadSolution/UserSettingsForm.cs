using src.DesignPatterns.Creational.AbstractFactory.BadSolution.Package;

namespace src.DesignPatterns.Creational.AbstractFactory.BadSolution
{ //user class of the package
    public class UserSettingsForm
    { 
        
        //the conditionals are problematic here
        public void Render(OperatingSystemType os)
        {
            if (os == OperatingSystemType.Windows)
            {
                new WindowsButton().Render();
                new WindowsCheckbox().Render();
            }
            else if (os == OperatingSystemType.Mac)
            {
                new MacButton().Render();
                new MacCheckbox().Render();
            }

        }
    }
}