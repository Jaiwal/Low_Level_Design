namespace src.DesignPatterns.Behavioral.Mediator.OnlyMediator
{
    public class UIControl
    {
        //all UIcontrol can talk to their owner(one)
        protected DialogBox _owner;

        public UIControl(DialogBox owner)
        {
            _owner = owner;
        }
    }
}
