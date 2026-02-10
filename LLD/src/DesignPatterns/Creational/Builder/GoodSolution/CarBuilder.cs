
using src.DesignPatterns.Creational.Builder.Components;

namespace src.DesignPatterns.Creational.Builder.GoodSolution
{
    public class CarBuilder : IBuilder
    {
        private Car _car;

        public CarBuilder()
        {
            Reset();
        }

        public void Reset()
        {
            _car = new Car();
        }

        public IBuilder IsConvertible(bool isConvertible)
        {
            throw new NotImplementedException();
        }


        public IBuilder SetCarType(CarType type)
        {
            _car.Type = type;
            return this;
        }

        public IBuilder SetDashBoard(DashBorad dashBorad)
        {
            _car.Dashboard = dashBorad;
            return this;
        }

        public IBuilder SetEngine(Engine engine)
        {
            _car.Engine = engine;
            return this;
        }

        public IBuilder SetGPSNavigator(GPSNavigator gPSNavigator)
        {
            _car.GpsNavigator = gPSNavigator;
            return this;
        }

        public IBuilder SetWheels(Wheels wheels)
        {
            _car.Wheels = wheels;
            return this;
        }

        public Car GetCar()
        {
            var car = _car;
            Reset();
            return car;
        }
    }
}