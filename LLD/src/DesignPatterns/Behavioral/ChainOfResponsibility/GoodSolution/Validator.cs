namespace src.DesignPatterns.Behavioral.COR.GoodSolution
{
    public class Validator : Handler
    {
        public override bool DoHandle(HttpRequest request)
        {
          
            var username = request.GetUsername();
            var password = request.GetPassword();


            //trim whitespace
            request.ValidatedUsername = username.Trim();
            request.ValidatedPassword = username.Trim();
            
            //stop here if either is empty else will go to next
            return request.ValidatedPassword == "" || request.ValidatedUsername == "";
        }
    }
}