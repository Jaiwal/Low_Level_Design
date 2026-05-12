namespace src.DesignPatterns.Behavioral.Command.HeadFirst.SimpleRemoteControl
{
    public class GarageDoorOpenCommand:ICommand{
        private readonly GarageDoor _garage;
        
        public GarageDoorOpenCommand(GarageDoor garageDoor){
            _garage=garageDoor;
        }
        public void Execute()
        {
            _garage.Up();
        }
    }
}