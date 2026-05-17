namespace src.DesignPatterns.Behavioral.Command.HeadFirst.RemoteControlWithUndo
{
    public class LightOffCommand : ICommand
    {
        private Light _light;
        private int _level;
        public LightOffCommand(Light light)
        {
            _light = light;
        }
        public void Execute()
        {
            _level = _light.GetLevel();
            _light.Off();
        }

        public void Undo()
        {
            _light.Dim(_level);
    
        }
    }
}