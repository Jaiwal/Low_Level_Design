

namespace src.DesignPatterns.Creational.FactoryMethod.GoodSolution.MVCFramework
{
    public class Controller
    {
        public void Render(string filename, Dictionary<string, object> data)
        {
            var newEngine = CreateViewEngine();
            var html = newEngine.Render(filename, data);
            System.Console.WriteLine(html);
        }

        protected virtual IViewEngine CreateViewEngine()
        {
            return new BladeViewEngine();
        }
    }
}