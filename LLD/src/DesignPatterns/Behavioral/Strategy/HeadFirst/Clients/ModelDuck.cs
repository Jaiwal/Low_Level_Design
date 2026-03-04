namespace src.DesignPatterns.Behavioral.Strategy.HeadFirst
{
    public class ModelDuck : Duck
    {

        public ModelDuck()
        {
            flyBehaviour = new FlyWithWings();
            quackBahaviour = new QuackSqeak(); //can define default behaviour
        }
        public override void Display()
        {
            Console.WriteLine("I am slim and trim, can you see");
        }
    }
}