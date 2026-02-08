
namespace src.DesignPatterns.Creational.FactoryMethod.BadSolution.MVCFramework
{
    public class Controller
    {
        public void Render(string filename, Dictionary<string, object> data)
        {
            var newEngine = new BladeViewEngine();
            var html = newEngine.Render(filename, data);
            System.Console.WriteLine(html);
        }
    }
}