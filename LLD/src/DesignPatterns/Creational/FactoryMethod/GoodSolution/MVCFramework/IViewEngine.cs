namespace src.DesignPatterns.Creational.FactoryMethod.BadSolution.MVCFramework
{

    public interface IViewEngine
    {
        string Render(string filename, Dictionary<string, object> data);
    }
}