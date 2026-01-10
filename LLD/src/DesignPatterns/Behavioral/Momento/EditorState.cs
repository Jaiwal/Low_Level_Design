namespace src.DesignPatterns.Behavioral.Momento
{  //Momento class/object, the one who maintain states
    public class EditorState
    {
        //read only because once this is created(State) it should not be changed
        private readonly string _title;
        private readonly string _content;

        //state meta data

        private readonly DateTime _stateCreatedAt;


        public EditorState(string title, string content)
        {
            _title = title;
            _content = content;
            _stateCreatedAt = DateTime.Now;
        }

        public string GetTitle()
        {
            return _title;
        }

        public string GetContent()
        {
            return _content;
        }

        public DateTime GetDate()
        {
            return _stateCreatedAt; ;
        }

        public string GetName()
        {
            return $"{_stateCreatedAt} / {_title}";
        }

 }
}