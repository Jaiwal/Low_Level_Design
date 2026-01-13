namespace src.DesignPatterns.Behavioral.Command.UndoWithCommandPattern
{
    public interface IUndoableCommand:ICommand
    {
        //this is also a command object too
        void Unexecute();
    }
}