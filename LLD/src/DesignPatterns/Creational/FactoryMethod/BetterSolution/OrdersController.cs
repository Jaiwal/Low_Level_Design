

using src.DesignPatterns.Creational.FactoryMethod.BetterSolution.MVCFramework;

namespace src.DesignPatterns.Creational.FactoryMethod.BetterSolution
{  //this is some other developer creating this using MVC framework
    public class OrdersController : Controller
    {
        public void ListOrders()
        {
            //simulating fetching users order from db
            var orders = new Dictionary<string, object>
            {
                {"Mukut","$120.49"},
                {"Kanthi","$70.33"},
                {"Tilak","$43.90"}
            };

            Render("orders.blade.php", orders,new TwigViewEngine());
        }

        public void GetOrder(int id)
        {
            //simulate getting single order by id from db
            var order = new Dictionary<string, object>
            {
                {"Kanthi","70.33"}
            };

            Render("order.php", order,new TwigViewEngine());
        }
    }
}