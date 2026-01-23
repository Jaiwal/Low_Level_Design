namespace src.DesignPatterns.Behavioral.Mediator.MediatorWithObserver.UIFramework
{

    //this would be subject class managing event handlers, keeping list of callbacks method for updating other UI component when user interacts with them

    public class UIControl
    {
        private List<EventHandler> _eventHandlers = new List<EventHandler>();

        public void AddEventHandler(EventHandler eventHandler)
        {
            _eventHandlers.Add(eventHandler);
        }

        //method to call the event handler

        public void NotifyEventHandler()
        {
            foreach (var handler in _eventHandlers)
            {
                handler();
            }
        }
    }
}