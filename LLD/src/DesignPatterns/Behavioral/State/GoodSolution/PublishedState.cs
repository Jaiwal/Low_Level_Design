

namespace src.DesignPatterns.Behavioral.State.GoodSolution
{
    public class PublishedState : IState
    {

        private Document _document;

        public PublishedState(Document document)
        {
            _document = document;
        }
        public void Publish()
        {
            return;
            //do nothing allready in publsihed state
        }
    }
}