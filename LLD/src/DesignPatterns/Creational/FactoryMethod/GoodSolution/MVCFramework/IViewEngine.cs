namespace src.DesignPatterns.Creational.FactoryMethod.GoodSolution.MVCFramework
{

    public interface IViewEngine
    {
        //sending data with a filename, which modifies and return that
        string Render(string filename, Dictionary<string, object> data);
    }
}