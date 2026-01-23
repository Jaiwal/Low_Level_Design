namespace src.DesignPatterns.Behavioral.COR.BadSolution
{
    public class Logger
    {
        public void Log(HttpRequest request)
        {
            System.Console.WriteLine("Loggin you now "+request.GetUsername());
        }
    }
    }