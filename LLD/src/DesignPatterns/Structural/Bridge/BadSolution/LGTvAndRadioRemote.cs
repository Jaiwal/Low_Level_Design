namespace src.DesignPatterns.Structural.Bridge.BadSolution
{
    public class LGTvAndRadioRemote : RadioAndTvRemote
    {
        public override void ControlRadio()
        {
            System.Console.WriteLine("Now controlling radio");
        }

        public override void ControlTV()
        {
             System.Console.WriteLine("Now controlling TV");
        }

        public override void TurnOff()
        {
              System.Console.WriteLine("Turning Lg/tv off");
        }

        public override void TurnOn()
        {
            System.Console.WriteLine("Turning Lg/tv on");
        }

        public override void VolumeDown()
        {
           System.Console.WriteLine("Turning Lg/tv volume down");
        }

        public override void VolumeUp()
        {
            System.Console.WriteLine("Turning Lg/tv volumne up");
        }
    }
}