namespace src.DesignPatterns.Behavioral.Strategy.HeadFirst
{
    public class FlyNoways : IFlyBehaviour
    {
        public void fly()
        {
            Console.WriteLine("I dont fly, stop making me");
        }
    }
}