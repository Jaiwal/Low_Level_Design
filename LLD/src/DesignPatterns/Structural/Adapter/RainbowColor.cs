using src.DesignPatterns.Structural.Adapter.Package;

namespace src.DesignPatterns.Structural.Adapter
{
    //this is a wrapper over color, we did it using composition
    public class RainbowColor : IColor
    {

        //composed of 3rd package
        private Rainbow _rainbow;

        public RainbowColor(Rainbow rainbow)
        {
            _rainbow = rainbow;
        }
        public void Apply(Video video)
        {
            _rainbow.SetUp();
            _rainbow.Update(video);
        }
    }
}