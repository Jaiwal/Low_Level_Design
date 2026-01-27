namespace src.DesignPatterns.Structural.Bridge.BadSolution
{
    public class AdvancedLGRemote : AdvancedRemote
    {
        public override void SetChannel(int channel)
        {
            System.Console.WriteLine("Turning LG channel to "+channel);
        }

        public override void TurnOff()
        {
           System.Console.WriteLine("Turning advanced LG tv off");
        }

        public override void TurnOn()
        {
            System.Console.WriteLine("Turning advanced LG tv on");
        }

        public override void VolumeDown()
        {
            System.Console.WriteLine("Turning advanced volume LG down");
        }

        public override void VolumeUp()
        {
            System.Console.WriteLine("Turning advanced LG tv up");
        }
    }
}