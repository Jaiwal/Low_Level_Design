namespace src.DesignPatterns.Behavioral.State.Stateprac
{
    public class Document
    {
        public IState State;

        public UserRoles UserRole;

        public Document(UserRoles userRole)
        {
            UserRole = userRole;
            State = new DraftState(this);
        }

        public void Publish()
        {
            State.Publish();
        }
    }
}