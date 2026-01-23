namespace src.DesignPatterns.Behavioral.COR.GoodSolution
{
    public class WebServer
    {
        //having reference for stating handler

        private Handler _handler;

        public WebServer(Handler handler)
        {
            _handler = handler;
        }

        public void Handle(HttpRequest request)
        {
            _handler.Handle(request);
        }
    }
}