namespace src.DesignPatterns.Structural.Adapter.Package
{
    public class Rainbow
    {
        public void SetUp()
        {
            System.Console.WriteLine("Setting up rainbow here");

        }
        

        //how it got video reference but i think it would take care how video are taken in object which would be same as video class defination
        public void Update(Video video)
        {
            System.Console.WriteLine("Applyig the fileter raibow to video");
        }
   }
}