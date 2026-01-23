
namespace src.DesignPatterns.Behavioral.COR.GoodSolution
{
    public abstract class Handler
    {
        private Handler _nextHandler;

        public Handler SetNext(Handler handler)
        {
            _nextHandler = handler;
            //returning handler for convienince like h1.next(h2).next(h3) like this
            return handler;
        }

        public void Handle(HttpRequest request)
        {
            if (DoHandle(request))
            {
                return;
            }

            if (_nextHandler != null) {
                _nextHandler.Handle(request);
            }
        }

        public abstract bool DoHandle(HttpRequest request);
    }
}