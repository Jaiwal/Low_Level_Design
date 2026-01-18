using System.Reflection.Metadata;

namespace src.DesignPatterns.Behavioral.State.Stateprac
{
    public class PublishedState : IState
    {
        private Document _doc;

        public PublishedState(Document document)
        {
            _doc = document;
        }
        public void Publish()
        {
           //nothing
        }
    }
}