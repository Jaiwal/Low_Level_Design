
// //coupling: the degree of dependency between classes

// //var order = new Order();
// //order.PlaceOrder(); //any change in email might need change in order class, therefore add abstraction by using interface instead


// var order = new Order(new EmailSender());
// order.PlaceOrder();

// //now we can do below, we've decoupled order class from specific implementation of notification service
// var order1 = new Order(new SmsSender());
// order1.PlaceOrder();




// //compistion: creating complex objects by combining simpler objects/components.Objecsts assembled while maintaining its own state and bahevaiour. often described 
// // as a has-a relationship
// var car = new Car();
// car.StartCar();

// /*
// use composition when there is 
// 1. has-a relationship more apt than is-a
// 3. avoiding fragile base class problem(Arises due to tight coupling)
// */


// using src.SOLID.L;

// //learning "L" in Solid
// var rect = new Rectangle();
// rect.Height = 10;
// rect.Width = 5;
// System.Console.WriteLine("Expected Area=50");
// System.Console.WriteLine("Calculated area=" + rect.Area
// );

// //but if you replace rectangle to square, this breaks
// // A Square cannot be substituted for a Rectangle without altering the program's behavior. 

// //below follows L
// Shape rectangle = new Rectangle { Width = 5, Height = 4 };
// System.Console.WriteLine($"Area of rectangel: {rectangle.Area}");

// Shape squre = new Square { SideLength = 6 };
// System.Console.WriteLine($"Area of square is: {squre.Area}");


// //learning I in SOLID

// using src.SOLID.I;

// var circle = new Circle();
// circle.Radius = 10;
// Console.WriteLine(circle.Area());
// //Console.WriteLine(circle.Volume()); //this will throw exception

// //when segregated


//learning D in SOlID
//using src.SOLID.D;

//there is no way to add type of engine as well, we would need to change that in car class then

//but since you created engine interface, on runtime, you can specify with which engine you want car to be built
//var car = new Car(new Engine()); //we are injecting dependency, called DI


//learning Momento

using src.DesignPatterns.Behavioral.Momento;

var editor = new Editor();
var history = new History(editor);
history.BackUp();
editor.Title = "Test";
history.BackUp();
editor.Content = "This is to test my name is Priya";
history.BackUp();
editor.Title = "Test again";

System.Console.WriteLine("Title : "+ editor.Title);
System.Console.WriteLine("Content : " + editor.Content);

history.Undo();


System.Console.WriteLine("Title : "+ editor.Title);
System.Console.WriteLine("Content : " + editor.Content);

history.ShowHistory();
history.Undo();

System.Console.WriteLine("Title : "+ editor.Title);
System.Console.WriteLine("Content : " + editor.Content);

history.Undo();

System.Console.WriteLine("Title : "+ editor.Title);
System.Console.WriteLine("Content : " + editor.Content);