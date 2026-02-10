using src.DesignPatterns.Creational.Builder.Components;

namespace src.DesignPatterns.Creational.Builder.GoodSolution
{
    public class CarManualBuilder : IBuilder
    {
        private Manual _manual;
       

        public void Reset()
        {
            throw new NotImplementedException();
        }

       

        public IBuilder IsConvertible(bool isConvertible)
        {
            _manual.Isconvertibe = true;
            return this;
        }


        public IBuilder SetCarType(CarType type)
        {
            _manual.Type = type;
            return this;
        }

        public IBuilder SetDashBoard(DashBorad dashBorad)
        {
            _manual.Dashboard = dashBorad;
            return this;
        }

        public IBuilder SetEngine(Engine engine)
        {
            _manual.Engine = engine;
            return this;
        }

        public IBuilder SetGPSNavigator(GPSNavigator gPSNavigator)
        {
            _manual.GpsNavigator = gPSNavigator;
            return this;
        }

        public IBuilder SetWheels(Wheels wheels)
        {
            _manual.Wheels = wheels;
            return this;
        }

    }
}