namespace src.DesignPatterns.Behavioral.GoodSolution.Command
{

    //receiver class, recieves from remote
    public class Light
    {
        public void TurnOn()
        {
            System.Console.WriteLine("Turning the lights on");
        }

        public void TurnOFF()
        {
            System.Console.WriteLine("Turning the lights Off");
        }
        
        public void Dim()
        {
            System.Console.WriteLine("Dimming the lights");
        }
    }
}