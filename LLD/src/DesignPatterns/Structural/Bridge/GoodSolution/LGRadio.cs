namespace src.DesignPatterns.Structural.Bridge.GoodSolution
{
    public class LGRadio : IDevice
    {
        public void SetChannel(int channel)
        {
            System.Console.WriteLine("setting tv on channel "+channel);
        }

        public void TurnOff()
        {
            System.Console.WriteLine("Turning LG tv off");
        }

        public void TurnOn()
        {
            System.Console.WriteLine("Turning LG tv on");
        }
    }
}