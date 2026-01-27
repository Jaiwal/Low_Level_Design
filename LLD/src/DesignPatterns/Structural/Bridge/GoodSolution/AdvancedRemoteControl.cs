namespace src.DesignPatterns.Structural.Bridge.GoodSolution
{
    public class AdvancedRemoteControl : RemoteControl
    {
        public AdvancedRemoteControl(IDevice device) : base(device)
        {
        }

        public void SetChannel(int channel)
        {
            System.Console.WriteLine("setting channel to " + channel);
        }
    }
}