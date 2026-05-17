namespace src.DesignPatterns.Behavioral.Command.HeadFirst.RemoteControlWithUndo
{
    public class LightOnCommand : ICommand
    {
        private Light _light;
        private int _level;

        public LightOnCommand(Light light)
        {
            _light = light;
        }
        public void Execute()
        {
            _level = _light.GetLevel();
            _light.On("Living Room");
            // Implementation for executing light on command
        }

        public void Undo()
        {
            _light.Dim(_level);
            // Implementation for undoing light on command
        }
    }
}