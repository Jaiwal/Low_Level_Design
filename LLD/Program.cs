
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
/*
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

*/

//------------------learning State----------------------------------------------
//wrong way to implement use case
// using src.DesignPatterns.Behavioral.State.BadSolution;

// var doc = new Document();
// doc.State = DocumentState.Moderation;
// doc.CurrentUserRoles = UserRoles.Admin;

// System.Console.WriteLine(doc.State);
// doc.Publish();
// System.Console.WriteLine(doc.State);

//right way using state

// using src.DesignPatterns.Behavioral.State.GoodSolution;

// var doc = new Document(UserRoles.Admin);
// System.Console.WriteLine(doc.State); //by default we are in drafestate
// doc.Publish();
// System.Console.WriteLine(doc.State);
// doc.Publish();
// System.Console.WriteLine(doc.State); //user is editor so wont go into publish
// //can also directly change the state
// doc.State = new DraftState(doc);
// System.Console.WriteLine(doc.State);

//------------------learning State----------------------------------------------



//-------------------learning strategy-----------------------------------------


// using src.DesignPatterns.Behavioral.Strategy.GoodSolu tion;

// var videoStorage = new VideoStorage(new CompressorMOV(), new OverlayBlackAndWhite());
// videoStorage.Store("/videos/primal-fear  ");

// //we have methods to change compressor or overlay in our class

// videoStorage.SetOverlay(new OverlayNone());
// videoStorage.SetCompressor(new CompressorMP4());
// videoStorage.Store("/videos/radhe  ");


//-------------------learning strategy-----------------------------------------

//-------------------learning iterator-----------------------------------------

// using src.DesignPatterns.Behavioral.Iterator;

// //this will cause problem in case data type(internal of object changes since fixed length does not have count function)
// ShoppingList list = new ShoppingList();
// list.Push("Milk");
// list.Push("Bread");
// list.Push("paneer");

// for (int i = 0; i < list.GetList().Count; i++)
// {
//     var item = list.GetList()[i];
//     System.Console.WriteLine(item);
// }

//using iterator

// using src.DesignPatterns.Behavioral.Iterator.GoodSolution;

// ShoppingList list = new ShoppingList();
// list.Push("Milk");
// list.Push("Bread");
// list.Push("paneer");

// var iterator = list.CreateIterator();

// while (iterator.HasNext())
// {
//     System.Console.WriteLine(iterator.Current());
//     iterator.Next();
// }

//-------------------learning iterator-----------------------------------------


//-------------------learning Command-----------------------------------------

// using src.DesignPatterns.Behavioral.BadSolution.Command;

// var light = new Light();
// var remoteControl = new RemoteControl(light);

// remoteControl.PressButton(true);
// remoteControl.PressButton(false);

// using src.DesignPatterns.Behavioral.GoodSolution.Command;

// var light = new Light();
// var remoteControl = new RemoteControl(new TurnOnCommand(light));
// remoteControl.PressButton();

// remoteControl.SetCommand(new DimCommand(light));
// remoteControl.PressButton();

//implementing undo with command

using src.DesignPatterns.Behavioral.Command.UndoWithCommandPattern;

var htmlDodc = new HtmlDocument();
var history = new History();

htmlDodc.Content = "New world";
System.Console.WriteLine(htmlDodc.Content);


var italicCommand = new Italic(htmlDodc, history);
italicCommand.Execute();
System.Console.WriteLine(htmlDodc.Content);

var undoCommand = new UndoCommand(history);
undoCommand.Execute();
System.Console.WriteLine(htmlDodc.Content);

//-------------------learning Command-----------------------------------------