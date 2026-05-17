namespace src.DesignPatterns.Behavioral.Command.HeadFirst.RemoteControlWithUndo
{
    public interface ICommand{
        public void Execute();
        public void Undo();
    }
}