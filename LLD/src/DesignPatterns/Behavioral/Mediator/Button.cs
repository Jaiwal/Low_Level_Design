namespace src.DesignPatterns.Behavioral.Mediator
{
    public class Button : UIControl
    {

        private bool _isEnable;
        public Button(DialogBox owner) : base(owner)
        {
        }

        public bool isEnabled()
        {
            return _isEnable;
        }

        public void SetEnable(bool isEnabled)
        {
            _isEnable = isEnabled;
            //again need to notify the owner by passing this object
            _owner.Changed(this);
        }
    }

}