

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

        //can also make it abstract
        //virtual and hence subclass method will be called(if invoked from subclass instance) else this one(in case this is abstract or invoked from parent object)
        protected virtual IViewEngine CreateViewEngine()
        {
            return new BladeViewEngine();
        }
    }
}