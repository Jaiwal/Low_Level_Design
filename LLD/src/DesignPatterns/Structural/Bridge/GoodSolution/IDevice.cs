namespace src.DesignPatterns.Structural.Bridge.GoodSolution
{
    public interface IDevice
    {
        public void TurnOn();

        public void TurnOff();


        public void SetChannel(int channel);  
    }
}