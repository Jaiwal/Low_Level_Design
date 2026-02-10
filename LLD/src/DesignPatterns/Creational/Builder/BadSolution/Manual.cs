using src.DesignPatterns.Creational.Builder.Components;


namespace src.DesignPatterns.Creational.Builder.BadSolution
{
    public class Manual
    {
        public CarType _type;

        public int _seats;

        public Engine _engine;

        public bool _isconvertibe;

        public DashBorad _dashboard;

        public Wheels _wheels;

        public GPSNavigator _gpsNavigator;

        public Manual(CarType type, int seats, Engine engine, bool isConvertible, DashBorad dashboard, Wheels wheels, GPSNavigator gpsNavigator)
        {
            _type = type;
            _seats = seats;
            _engine = engine;
            _isconvertibe = isConvertible;
            _dashboard = dashboard;
            _wheels = wheels;
            _gpsNavigator = gpsNavigator;

        }

        public string Print()
        {
            var text = "";

            text += "car type" + _type + "\n";
            text += "Seats " + _seats + "\n";
            text += "Wheels diameter in inches " + _wheels.GetDiamterInInches() + "\n";
            text += "Engine info: " + "\n";
            text += "GPS navigator";
            if (_gpsNavigator!=null)
            {
                text += "some other gps info";
            }

            return text;
        }
    }
}