namespace src.DesignPatterns.Behavioral.GoodSolution.Command
{
    public class RemoteControl
    {
        private ICommand _command;

        public RemoteControl(ICommand command)
        {
            _command = command;
        }

        //for user to set the command if they like whenever
        public void SetCommand(ICommand command)
        {
            _command = command;
        }

        public void PressButton()
        {
            _command.Execute();
        }   
}
}