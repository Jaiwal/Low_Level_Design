namespace src.DesignPatterns.Behavioral.Command.HeadFirst.RemoteControlWithUndo
{
    public class Light
    {
        private readonly string _location;
        private int _level;

        public Light(string location)
        {
            _location = location;
        }
        public void On(string location)
        {
            _level = 100;
            Console.WriteLine($"{_location} light is on");
        }

        public void Off()
        {
            _level = 0;
            Console.WriteLine($"{_location} light is off");

        }

        public void Dim(int level)
        {
            _level = level;
            if (_level == 0)
            {
                Off();
            }
            else
            {
                Console.WriteLine($"{_location} light is dimmed to {_level}%");
            }
        }

        public int GetLevel()
        {
            return _level;
    }
}}