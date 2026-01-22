namespace src.DesignPatterns.Behavioral.Mediator
{    //understand this class as collection of Ui components
    public abstract class DialogBox
    {
        public abstract void Changed(UIControl uIControl);
    }
}