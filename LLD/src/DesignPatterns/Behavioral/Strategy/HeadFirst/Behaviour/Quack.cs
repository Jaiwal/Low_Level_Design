namespace src.DesignPatterns.Behavioral.Strategy.HeadFirst
{
    public class Quack : IQuackBahaviour
    {

        void IQuackBahaviour.Quack()
        {
            Console.WriteLine("I am normal quack quack");
        }
    }
}


/*

Quack quack = new Quack();
// quack.Quack(); // This will NOT work because Quack() is not part of the class's public API.

IQuackBahaviour quackBehavior = new Quack();
quackBehavior.Quack(); // This works because Quack() is accessed through the interface.


No Access Modifier: Explicit interface methods are implicitly private to the class and cannot have an access modifier.
Access Through Interface: The method can only be called when the object is cast to the interface type.
*/