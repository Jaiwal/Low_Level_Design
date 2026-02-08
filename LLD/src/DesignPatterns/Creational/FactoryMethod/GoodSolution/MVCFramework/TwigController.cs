namespace src.DesignPatterns.Creational.FactoryMethod.GoodSolution.MVCFramework
{
    public class TwigController : Controller
    {
        protected override IViewEngine CreateViewEngine()
        {
            return new TwigViewEngine();
        }
    }
}