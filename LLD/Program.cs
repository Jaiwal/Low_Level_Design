




//coupling: the degree of dependency between classes

//var order = new Order();
//order.PlaceOrder(); //any change in email might need change in order class, therefore add abstraction by using interface instead


var order = new Order(new EmailSender());
order.PlaceOrder();

//now we can do below, we've decoupled order class from specific implementation of notification service
var order1 = new Order(new SmsSender());
order1.PlaceOrder();






//compistion: creating complex objects by combining simpler objects/components.Objecsts assembled while maintaining its own state and bahevaiour. often described 
// as a has-a relationship


var car = new Car();
car.StartCar();
