namespace src.DesignPatterns.Behavioral.COR.GoodSolution
{
    public class Logger:Handler
    {
        public override bool DoHandle(HttpRequest request)
        {
            System.Console.WriteLine("Loggin you now" + request.GetUsername());
            //this can never fail step type of handler
            return false;
        }

    }
    }