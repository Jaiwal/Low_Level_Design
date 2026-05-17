namespace src.DesignPatterns.Behavioral.Command.HeadFirst.RemoteControlWithUndo
{
    public class FanLowCommand : ICommand
    {
        private Fan _fan;
        private int _prevSpeed;

        public FanLowCommand(Fan fan)
        {
            _fan = fan;
        }
        public void Execute()
        {
            _prevSpeed = _fan.GetSpeed();
            _fan.Low();
            // Implementation for executing fan low  command
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
            // Implementation for undoing fan low  command
        }
    }
}