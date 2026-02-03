namespace src.DesignPatterns.Creational.Singleton.BadSolution
{
    public class Test
    {
        //static for convienience
        public static void Run()
        {
            var settings = new AppSettings();
            System.Console.WriteLine(settings.Get("app_name"));
        }
    }
}