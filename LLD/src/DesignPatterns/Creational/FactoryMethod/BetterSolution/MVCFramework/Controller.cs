

namespace src.DesignPatterns.Creational.FactoryMethod.BetterSolution.MVCFramework
{  
    public class Controller
    {
        public void Render(string filename, Dictionary<string, object> data,IViewEngine viewEngine)
        {
            //var newEngine = new BladeViewEngine(); //now you have more control
            var html = viewEngine.Render(filename, data);
            System.Console.WriteLine(html);
        }
    }
}