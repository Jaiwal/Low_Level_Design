namespace src.DesignPatterns.Behavioral.Command.UndoWithCommandPattern
{
    public class HtmlDocument
    {
        //business layer of application, no knowledge of commands
        public string Content { get; set; }

        public void MakeItalic()
        {
            Content = "<i>" + Content + "<i>";
        }
    }
}