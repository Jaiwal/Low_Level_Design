namespace src.DesignPatterns.Behavioral.Strategy.HeadFirst
{
    public class MallardDuck : Duck
    {

        public MallardDuck()
        {
            flyBehaviour = new FlyNoways();
            quackBahaviour = new Quack(); //can define default behaviour
        }
        public override void Display()
        {
            Console.WriteLine("I am wicked idk, can you see");
        }
    }
}