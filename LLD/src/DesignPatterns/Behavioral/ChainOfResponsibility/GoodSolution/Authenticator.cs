namespace src.DesignPatterns.Behavioral.COR.GoodSolution
{
    public class Authenticator :Handler
    {

        public override bool DoHandle(HttpRequest request)
        {
            System.Console.WriteLine("Authenticating");
            var username = request.GetUsername();
            var password = request.GetPassword();
            //if this is user then we go ahead
            return !(username == "Priya" && password == "123");
        }
    }
}