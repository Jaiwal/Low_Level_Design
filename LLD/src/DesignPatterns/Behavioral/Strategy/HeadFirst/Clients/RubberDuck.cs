namespace src.DesignPatterns.Behavioral.Strategy.HeadFirst
{
    public class RubberDuck : Duck
    {

        public RubberDuck()
        {
            flyBehaviour = new FlyWithWings();
            quackBahaviour = new QuackMute(); //can define default behaviour
        }
        public override void Display()
        {
            Console.WriteLine("I am made of rubber, can you see");
        }
    }
}