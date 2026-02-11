
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
            _car.Isconvertibe = true;
            return this;
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
        
        //this returns the car object, not necessary but optional in this pattern, maybe useful in some cases
        public Car GetCar()
        {
            var car = _car;
            Reset();
            return car; 
        }

        public IBuilder SetSeats(int seats)
        {
            _car.Seats = seats;
            return this;
        }
    }
}