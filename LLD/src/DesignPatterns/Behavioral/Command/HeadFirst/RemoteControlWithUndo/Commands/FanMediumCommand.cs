namespace src.DesignPatterns.Behavioral.Command.HeadFirst.RemoteControlWithUndo
{
    public class FanMediumCommand : ICommand
    {
        private Fan _fan;
        private int _prevSpeed;

            public FanMediumCommand(Fan fan)
            {
                _fan = fan; }

        public void Execute()
        {
            _prevSpeed = _fan.GetSpeed();
            _fan.Medium();
            // Implementation for executing fan medium command
        }

        public void Undo()
        {   
            switch (_prevSpeed)
            {
                case Fan.HIGH:
                    _fan.High();
                    break;
                case Fan.MEDIUM:
                    _fan.Medium();
                    break;
                case Fan.LOW:
                    _fan.Low();
                    break;
                default:
                    _fan.Off();
                    break;
            }
            // Implementation for undoing fan medium command
        }
    }
}