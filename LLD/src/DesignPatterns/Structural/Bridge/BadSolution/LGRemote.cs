namespace src.DesignPatterns.Structural.Bridge.BadSolution
{
    public class LGRemote : RemoteControl
    {
        public override void TurnOff()
        {
            System.Console.WriteLine("Turning LG tv off");
        }

        public override void TurnOn()
        {
           System.Console.WriteLine("Turning LG tv on");
        }

        public override void VolumeDown()
        {
            System.Console.WriteLine("Turning LG tv voumne down");
        }

        public override void VolumeUp()
        {
            System.Console.WriteLine("Turning LG tv volume up");
        }
    }
}