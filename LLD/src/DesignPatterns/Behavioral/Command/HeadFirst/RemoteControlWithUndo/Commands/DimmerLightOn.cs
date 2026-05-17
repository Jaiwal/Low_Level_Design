namespace src.DesignPatterns.Behavioral.Command.HeadFirst.RemoteControlWithUndo
{
    public class DimmerLightOn : ICommand
    {
        private Light _light;
        private int _level;

        public DimmerLightOn(Light light)
        {
            _light = light;
        }

        public void Execute()
        {
            _level = _light.GetLevel();
            _light.Dim(45);
            // Implementation for executing dimmer light on command
        }

        public void Undo()
        {
            _light.Dim(_level);
            // Implementation for undoing dimmer light on command
        }
    }
}