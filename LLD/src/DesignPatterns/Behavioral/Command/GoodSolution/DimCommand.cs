namespace src.DesignPatterns.Behavioral.GoodSolution.Command
{
    public class DimCommand : ICommand
    {

        private Light _light;


       //command is immutable once its done so not set get method
        public DimCommand(Light light)
        {
            _light = light;
        }
        public void Execute()
        {
            _light.Dim();
        }
    }
}