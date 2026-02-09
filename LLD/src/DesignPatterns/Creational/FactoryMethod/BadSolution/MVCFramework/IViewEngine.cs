namespace src.DesignPatterns.Creational.FactoryMethod.BadSolution.MVCFramework
{

    public interface IViewEngine
    {
        //sending data with a filename, which modifies and return that
        string Render(string filename, Dictionary<string, object> data);
    }
}