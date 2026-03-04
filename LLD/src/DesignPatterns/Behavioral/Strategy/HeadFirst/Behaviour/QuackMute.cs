namespace src.DesignPatterns.Behavioral.Strategy.HeadFirst
{
    public class QuackMute : IQuackBahaviour
    {
    
        public void Quack()
        {
            Console.WriteLine("My mouth moves but there wont be any noise");
        }
    }
}