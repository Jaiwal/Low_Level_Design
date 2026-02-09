
namespace src.DesignPatterns.Creational.FactoryMethod.BadSolution.MVCFramework
{  //this is part of MVC folder which is installed from outside in our project(say)
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