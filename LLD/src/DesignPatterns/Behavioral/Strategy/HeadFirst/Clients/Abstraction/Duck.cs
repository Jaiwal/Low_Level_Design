namespace src.DesignPatterns.Behavioral.Strategy.HeadFirst
{

    public abstract class Duck
    {
        public IFlyBehaviour flyBehaviour { get; set; }
        public IQuackBahaviour quackBahaviour { get; set; }

        public Duck()
        {

        }
        public abstract void Display();

        public void PerformFly()
        {
            flyBehaviour.fly();
        }

        public void PerformQuack()
        {
            quackBahaviour.Quack();
        }

        public void Swim()
        {
            Console.WriteLine("All ducks float yaar, should float");
        }
    }


}