

using src.DesignPatterns.Creational.FactoryMethod.GoodSolution.MVCFramework;

namespace src.DesignPatterns.Creational.FactoryMethod.GoodSolution
{  
    public class OrdersController : TwigController
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

            Render("orders.blade.php", orders);
        }

        public void GetOrder(int id)
        {
            //simulate getting single order by id from db
            var order = new Dictionary<string, object>
            {
                {"Kanthi","70.33"}
            };

            Render("order.php", order);
        }
    }
}