
namespace src.DesignPatterns.Behavioral.State.GoodSolution
{
    public class ModerationState : IState
    {

        private Document _document;

        public ModerationState(Document document)
        {
            _document = document;
        }
        public void Publish()
        {
            //need to check if user is admin then call publishstate
            if (_document.CurrentUserRoles == UserRoles.Admin)
            {
                _document.State =new PublishedState(_document);
            }
        }
    }
}