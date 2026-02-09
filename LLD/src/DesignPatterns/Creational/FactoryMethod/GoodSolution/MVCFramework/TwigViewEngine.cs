
namespace src.DesignPatterns.Creational.FactoryMethod.GoodSolution.MVCFramework
{
    public class TwigViewEngine : IViewEngine
    {
        public string Render(string filename, Dictionary<string, object> data)
        {
            return "View rendered from " + filename + " by Twig";
        }
    }
}