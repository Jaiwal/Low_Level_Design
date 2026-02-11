using src.DesignPatterns.Creational.Builder.Components;

namespace src.DesignPatterns.Creational.Builder.GoodSolution
{
    public class Director
    {
        public void ConstructSportsCar(IBuilder builder)
        {
            builder.SetCarType(CarType.Sports)
                    .SetSeats(4)
                    .SetEngine(new Engine())
                    .SetDashBoard(new DashBorad(hasRevCounter: true))
                    .SetWheels(new Wheels(23));

        }

        public void ConstructSUV(IBuilder builder)
        {
            builder.SetCarType(CarType.SUV)
                    .SetSeats(5)
                    .SetEngine(new Engine())
                    .SetDashBoard(new DashBorad(hasRevCounter: true))
                    .SetGPSNavigator(new GPSNavigator())
                    .SetWheels(new Wheels(23));

        }
        
    }
}