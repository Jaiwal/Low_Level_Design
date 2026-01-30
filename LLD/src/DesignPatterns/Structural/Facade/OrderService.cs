namespace src.DesignPatterns.Structural.Facade
{
    public class OrderService
    {
        //act as a facade that will take care of client interaction


        public void Order(OrderRequest orderRequest)
        {

            var orderReq = orderRequest;
            var authenticator = new Authenticate();
            var inventory = new Inventory();
            //check for all item existence
            foreach (var id in orderReq.Itemids)
                {
                     inventory.CheckInventory(id);
                }

            var payment = new Payment(orderReq.Name, orderReq.CardNumber, orderReq.Amount);
            payment.Pay();

            var orderFulfillment = new OrderFulfillment(inventory);
            orderFulfillment.fulfill(orderReq.Name, orderReq.Address, orderReq.Itemids);

        }
    }
}