namespace src.DesignPatterns.Behavioral.BadSolution.Command
{
    public class RemoteControl
    {
        private Light _light;

        public RemoteControl(Light light)
        {
            _light = light;
        }

        public void PressButton(bool turnOn)
        {
            if (turnOn)
            {
                _light.TurnOn();
            }
            else {
                _light.TurnOFF();
            }
        }
    }
}