namespace src.DesignPatterns.Behavioral.State.BadSolution
{
    public class Document
    {
        public DocumentState State { get; set; }

        public UserRoles CurrentUserRoles { get; set; }
        
        //below method is violating open-closed principal, will have to modify incase more user and state gets added
        public void Publish()
        {
            if (State == DocumentState.Draft)
            {
                //can check if user is admin then make state directly as published
                State = DocumentState.Moderation;
            }
            else if (State == DocumentState.Moderation)
            {
                if (CurrentUserRoles == UserRoles.Admin)
                {
                    State = DocumentState.Published;
                }
            }
            else if (State == DocumentState.Published)
            {
                //nothing need to be done 
            }
        }
    }
}