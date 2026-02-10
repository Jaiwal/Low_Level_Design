using src.DesignPatterns.Creational.Builder.Components;


namespace src.DesignPatterns.Creational.Builder.GoodSolution
{
    public class Manual
    {
        public CarType Type{ get; set; }

        public int Seats{ get; set; }

        public Engine Engine{ get; set; }

        public bool Isconvertibe{ get; set; }

        public DashBorad Dashboard{ get; set; }

        public Wheels Wheels{ get; set; }

        public GPSNavigator GpsNavigator{ get; set; }

    
        public string Print()
        {
            var text = "";

            text += "car type" + Type + "\n";
            text += "Seats " + Seats + "\n";
            text += "Wheels diameter in inches " + Wheels.GetDiamterInInches() + "\n";
            text += "Engine info: " + "\n";
            text += "GPS navigator";
            if (GpsNavigator!=null)
            {
                text += "some other gps info";
            }

            return text;
        }
    }
}