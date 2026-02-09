namespace src.DesignPatterns.Creational.Singleton.GoodSolution
{
    public class Test
    {
        //static for convienience
        public static void Run()
        {
            //giving error stating not accesible since obbiously we cane "new" it
            // var settings = new AppSettings();


            //now the same instance of appsettings will be used here therefore will have access to app_name
            var instance=AppSettings.GetInstance();
            System.Console.WriteLine(instance.Get("app_name"));
        }
    }
}