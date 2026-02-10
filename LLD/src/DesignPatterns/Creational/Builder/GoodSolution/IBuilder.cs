using src.DesignPatterns.Creational.Builder.Components;

namespace src.DesignPatterns.Creational.Builder.GoodSolution
{
    public interface IBuilder
    {
        void Reset(); //reset the object to brand new

        IBuilder SetCarType(CarType type);

        IBuilder IsConvertible(bool isConvertible);

        IBuilder SetEngine(Engine engine);

        IBuilder SetWheels(Wheels wheels);

        IBuilder SetDashBoard(DashBorad dashBorad);

        IBuilder SetGPSNavigator(GPSNavigator gPSNavigator);

    }
}