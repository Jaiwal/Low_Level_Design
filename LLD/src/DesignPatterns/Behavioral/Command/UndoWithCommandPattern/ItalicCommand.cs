namespace src.DesignPatterns.Behavioral.Command.UndoWithCommandPattern
{
    public class Italic : IUndoableCommand
    {

        private HtmlDocument _doc;

        protected string _prevContent = "";

        private History _history;

        public Italic(HtmlDocument doc, History history)
        {
            _doc = doc;
            _history = history;
        }
        public void Execute()
        {
            _prevContent = _doc.Content;
            _doc.MakeItalic(); //delegated this to doc business object, not doing inside command
            _history.Push(this);
        }

        public void Unexecute()
        {
            _doc.Content = _prevContent;
        }
    }
}