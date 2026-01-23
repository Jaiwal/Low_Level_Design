namespace src.DesignPatterns.Behavioral.COR.BadSolution
{
    public class WebServer
    {

        public void Handle(HttpRequest request)
        {
            //order matters here which would cause problem later, OCP violate 
            //also using new keyword, tightly coupled to concrete classes
            var validator = new Validator();
            validator.Validate(request);

            var authenticate = new Authenticator();
            authenticate.Authenticae(request);

            var logger = new Logger();
            logger.Log(request);

        }
    }
    }