




//coupling: the degree of dependency between classes
//var order = new Order();
//order.PlaceOrder(); //any change in email might need change in order class, therefore add abstraction by using interface instead


var order = new Order(new EmailSender());
order.PlaceOrder();

//now we can do
var order1 = new Order(new SmsSender());
order1.PlaceOrder();