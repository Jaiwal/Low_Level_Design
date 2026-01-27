namespace src.DesignPatterns.Structural.Bridge.BadSolution
{
    public abstract class RadioAndTvRemote : RemoteControl
    {
        public abstract void ControlTV();

        public abstract void ControlRadio();
    }
}