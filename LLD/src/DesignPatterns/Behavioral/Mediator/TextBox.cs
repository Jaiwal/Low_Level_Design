namespace src.DesignPatterns.Behavioral.Mediator
{
    public class TextBox : UIControl
    {

        private string _text = "";
        public TextBox(DialogBox owner) : base(owner)
        {
        }

        public string GetText()
        {
            return _text;
        }

        public void SetText(string text)
        {
            _text = text;
            //again need to notify the owner by passing this object
            _owner.Changed(this);
        }
    }

}