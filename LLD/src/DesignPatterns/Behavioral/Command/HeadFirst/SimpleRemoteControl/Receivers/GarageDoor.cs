namespace src.DesignPatterns.Behavioral.Command.HeadFirst.SimpleRemoteControl
{
    public class GarageDoor{
        public void Up() => Console.WriteLine("Garage Up");
        public void Down()=> Console.WriteLine("Garage down");
        public void Stop() => Console.WriteLine("Stopped garage");
        public void LightOn()=> Console.WriteLine("Garage light On");
        public void LightOff() => Console.WriteLine("Garage light Off");
        
    }
}