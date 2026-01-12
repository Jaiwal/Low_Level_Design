namespace src.DesignPatterns.Behavioral.BadSolution.Command
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
    }
}