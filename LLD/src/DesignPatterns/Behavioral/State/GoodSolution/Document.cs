
namespace src.DesignPatterns.Behavioral.State.GoodSolution
{
    public class Document
    {
        public IState State { get; set; }

        public UserRoles CurrentUserRoles { get; set; }

        public Document(UserRoles currentUserRole)
        {
            State = new DraftState(this);
            CurrentUserRoles = currentUserRole;
        }

        public void Publish()
        {
            State.Publish();
        }
    } 
}
