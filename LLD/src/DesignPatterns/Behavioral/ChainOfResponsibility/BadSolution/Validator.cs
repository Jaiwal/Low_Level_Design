namespace src.DesignPatterns.Behavioral.COR.BadSolution
{
    public class Validator
    {
        public void Validate(HttpRequest request)
        {
            var username = request.GetUsername();
            var password = request.GetPassword();


            //trim whitespace
            request.ValidatedUsername = username.Trim();
            request.validatedPassword = username.Trim();
        }

    }
}