namespace src.DesignPatterns.Behavioral.Command.HeadFirst.RemoteControlWithUndo
{
    public class Fan
    {
       private readonly string _location;

       private int _speed;

       public Fan(string location)
        {
            _location=location;
        }

        public const int OFF = 0;
        public const int LOW = 1;
        public const int MEDIUM = 2;
        public const int HIGH = 3;
        
        public void High()
        {
            _speed = HIGH;
            Console.WriteLine($"{_location} fan is on high");
        }

        public void Medium()
        {
            _speed = MEDIUM;
            Console.WriteLine($"{_location} fan is on medium");
        }

        public void Low()
        {
            _speed = LOW;
            Console.WriteLine($"{_location} fan is on low");
        }

        public void Off()
        {
            _speed = OFF;
            Console.WriteLine($"{_location} fan is off");
        }
        public int GetSpeed()
        {
            return _speed;
        }


    }
}