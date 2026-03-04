namespace src.DesignPatterns.Behavioral.Strategy.HeadFirst
{
    public class DecoyDuck : Duck
    {

        public DecoyDuck()
        {
            flyBehaviour = new FlyRocketPower();
            quackBahaviour = new QuackMute(); //can define default behaviour
        }
        public override void Display()
        {
            Console.WriteLine("I am made some military duck, can you see");
        }
    }
}