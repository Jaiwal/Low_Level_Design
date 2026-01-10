// namespace src.SOLID.D
// {
//     public class Car
//     {
//         private Engine engine;

//         public Car()
//         {
//             this.engine = new Engine();
//             //car has direct dependency on engine class, tight coupling
//             //if engine class changed, this will change/break here
//             //might need to update engine as well
//         }

//         public void StartCar()
//         {
//             engine.Start();
//             Console.WriteLine("Car has started");
//         }
//     }

// }

//car should depend on an abstraction
namespace src.SOLID.D
{
    public class Car
    {
        private IEngine engine; //some abstract engine we have

        public Car(IEngine engine)
        {
            this.engine = engine;
            //here you can pass type of engine when creating car
        }

        public void StartCar()
        {
            engine.Start();
            Console.WriteLine("Car has started");
        }
    }

}