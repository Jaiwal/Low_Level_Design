using src.DesignPatterns.Structural.Adapter.Package;

namespace src.DesignPatterns.Structural.Adapter
{
    //this is a wrapper over color, we did it using inheritance but its not that flexible since only 1 class you
    //can extend which is not the case with interface i.e using compisition 
   //if color was not interface then would be a problem
    public class RainbowAdapter : Rainbow, IColor
    {

        public void Apply(Video video)
        {
            SetUp();
            Update(video);
        }
    }
}