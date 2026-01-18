using System.Reflection.Metadata;

namespace src.DesignPatterns.Behavioral.State.Stateprac
{
    public class DraftState : IState
    {
        private Document _doc;

        public DraftState(Document document)
        {
            _doc = document;
        }
        public void Publish()
        {
            _doc.State = new ModerationState(_doc);
        }
    }
}