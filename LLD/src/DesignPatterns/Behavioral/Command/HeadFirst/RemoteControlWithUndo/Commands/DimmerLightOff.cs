namespace src.DesignPatterns.Behavioral.Command.HeadFirst.RemoteControlWithUndo
{
    public class DimmerLightOff : ICommand
    {
        private Light _light;
        private int _prevLevel;

        public DimmerLightOff(Light light)
        {
            _light = light;
             _prevLevel = 100;
        }
        public void Execute()
        {
           
            _light.GetLevel();
            _light.Off();
            // Implementation for executing dimmer light off command
        }

        public void Undo()
        {
            _light.Dim(_prevLevel);
            // Implementation for undoing dimmer light off command
        }
    }
}