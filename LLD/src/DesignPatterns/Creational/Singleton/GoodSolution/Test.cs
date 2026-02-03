namespace src.DesignPatterns.Creational.Singleton.GoodSolution
{
    public class Test
    {
        //static for convienience
        public static void Run()
        {
            //giving error stating not accesible since obbiously we cane "new" it
            // var settings = new AppSettings();

            var instance=AppSettings.GetInstance();
            System.Console.WriteLine(instance.Get("app_name"));
        }
    }
}