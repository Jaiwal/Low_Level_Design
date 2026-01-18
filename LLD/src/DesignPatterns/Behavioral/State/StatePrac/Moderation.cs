using System.Reflection.Metadata;

namespace src.DesignPatterns.Behavioral.State.Stateprac
{
    public class ModerationState : IState
    {
        private Document _doc;

        public ModerationState(Document document)
        {
            _doc = document;
        }
        public void Publish()
        {
            if (_doc.UserRole == UserRoles.Admin)
            {
                _doc.State = new PublishedState(_doc);
            }
        }
    }
}