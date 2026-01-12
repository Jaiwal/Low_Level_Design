namespace src.DesignPatterns.Behavioral.GoodSolution.Command
{
    public class TurnOnCommand : ICommand
    {

        private Light _light;


       //command is immutable once its done so not set get method
        public TurnOnCommand(Light light)
        {
            _light = light;
        }
        public void Execute()
        {
            _light.TurnOn();
        }
    }
}