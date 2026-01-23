namespace src.DesignPatterns.Behavioral.Mediator.MediatorWithObserver.UIFramework
{
     public class Button : UIControl
    {

        private bool _isEnable;

        public bool isEnabled()
        {
            return _isEnable;
        }

        public void SetEnable(bool isEnabled)
        {
            _isEnable = isEnabled;
            NotifyEventHandler();
        }
    }

}