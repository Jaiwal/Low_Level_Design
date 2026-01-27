namespace src.DesignPatterns.Structural.Bridge.GoodSolution
{
    public class SonyRadio : IDevice
    {
        public void SetChannel(int channel)
        {
            System.Console.WriteLine("setting tv on channel "+channel);
        }

        public void TurnOff()
        {
            System.Console.WriteLine("Turning sony tv off");
        }

        public void TurnOn()
        {
            System.Console.WriteLine("Turning sony tv on");
        }
    }
}