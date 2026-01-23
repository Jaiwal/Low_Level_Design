using src.DesignPatterns.Behavioral.Mediator.MediatorWithObserver.UIFramework;

namespace src.DesignPatterns.Behavioral.Mediator.MediatorWithObserver
{
    //its both mediator and observer now
    public class PostDialogBox
    {
        //declare fiels for UI componenets

        private ListBox _postListBox;
        private TextBox _titleTextBox;

        private Button _saveButton;

        public PostDialogBox()
        {
            _postListBox = new ListBox();
            _titleTextBox = new TextBox();
            _saveButton = new Button();

            _postListBox.AddEventHandler(PostSelected);
            _titleTextBox.AddEventHandler(TitleChanged);
        }

        public void SimulateUserInteraction()
        {
            _postListBox.SetSelection("Posting again");
            //_titleTextBox.SetText("");
            System.Console.WriteLine("Title text box " + _titleTextBox.GetText());
            System.Console.WriteLine("Button enabled :" + _saveButton.isEnabled());

        }
         private void PostSelected()
        {
            _titleTextBox.SetText(_postListBox.GetSelection());
            _saveButton.SetEnable(true);
        }

        private void TitleChanged()
        {
            bool isTitleEmpty = _titleTextBox.GetText() == "";
                _saveButton.SetEnable(!isTitleEmpty);
        }
    }
}