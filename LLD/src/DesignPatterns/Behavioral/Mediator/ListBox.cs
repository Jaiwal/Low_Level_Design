namespace src.DesignPatterns.Behavioral.Mediator
{
    public class ListBox : UIControl
    {
        private string _selection = "";
        public ListBox(DialogBox owner) : base(owner)
        {
        }

        public string GetSelection()
        {
            return _selection;
        }

        public void SetSelection(String selection)
        {
            _selection = selection;
            //now notify the owner that i have changed
            _owner.Changed(this);
        }
    }
}