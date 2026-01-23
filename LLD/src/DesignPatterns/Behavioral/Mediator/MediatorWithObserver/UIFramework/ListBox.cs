namespace src.DesignPatterns.Behavioral.Mediator.MediatorWithObserver.UIFramework
{

    public class ListBox : UIControl
    {
        private string _selection = "";
       

        public string GetSelection()
        {
            return _selection;
        }

        public void SetSelection(String selection)
        {
            _selection = selection;
            NotifyEventHandler();
        }
    }
}