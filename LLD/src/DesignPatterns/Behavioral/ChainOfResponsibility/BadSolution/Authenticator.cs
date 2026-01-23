namespace src.DesignPatterns.Behavioral.COR.BadSolution
{
    public class Authenticator
    {
        public bool Authenticae(HttpRequest request)
        {
            var username = request.GetUsername();
            var password = request.GetPassword();


            return username == "Priya" && password == "123";
        }

    }
}