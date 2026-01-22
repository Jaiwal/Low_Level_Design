namespace src.DesignPatterns.Behavioral.Mediator
{

    //concrete mediator class
    public class PostDialogBox : DialogBox
    {

        //fields for all UI components

        private ListBox _postsListBox;
        private TextBox _titleTextBox;

        private Button _saveButton;

        public PostDialogBox()
        {
            _postsListBox = new ListBox(this);
            _titleTextBox = new TextBox(this);
            _saveButton = new Button(this);
            //initally the button should be disabled
            _saveButton.SetEnable(false);
        }

        //handle/simulate user interaction

        public void SimulateUserInteraction()
        {
            _postsListBox.SetSelection("Post 2");
            _titleTextBox.SetText("");
            System.Console.WriteLine("Title text box " + _titleTextBox.GetText());
            System.Console.WriteLine("Button enabled :" + _saveButton.isEnabled());
        }
        
        //now all business logic here is in one class, easy to read and understand
        public override void Changed(UIControl uIControl)
        {
            //now we have everything

            //this means postlistbox changed so we set the text and set the button as enable
            if (uIControl == _postsListBox)
            {
                HandlePostListChanged();

            }
            else if (uIControl == _titleTextBox)
            {
                HandleTextBoxChanged();

            }
        }


        private void HandlePostListChanged()
        {
            _titleTextBox.SetText(_postsListBox.GetSelection());
            _saveButton.SetEnable(true);
        }

        private void HandleTextBoxChanged()
        {
            bool isTitleEmpty = _titleTextBox.GetText() == "";
                _saveButton.SetEnable(!isTitleEmpty);
        }
    }
}