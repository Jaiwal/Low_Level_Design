using src.DesignPatterns.Creational.Builder.Components;


namespace src.DesignPatterns.Creational.Builder.GoodSolution
{
    public class Car
    {
        public CarType Type{ get; set; } //now we have properties, not fields like before, can use fields too though

        public int Seats{ get; set; }

        public Engine Engine{ get; set; }

        public bool Isconvertibe{ get; set; }

        public DashBorad Dashboard{ get; set; }

        public Wheels Wheels{ get; set; }

        public GPSNavigator GpsNavigator{ get; set; }

        //fields specific to this class

        public double Fuel { get; set; }
    }
}