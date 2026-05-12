namespace src.DesignPatterns.Behavioral.Command.HeadFirst.SimpleRemoteControl
{
    public class Light{
        public void On() => Console.WriteLine("Lights are on now");
        public void Off()=> Console.WriteLine("Lights are off now");
    }
}