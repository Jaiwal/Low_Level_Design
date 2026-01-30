namespace src.DesignPatterns.Structural.Facade
{
    //request object containing user submitted data

    public class OrderRequest
    {
        public string Name { get; } = "Priya";
        public string CardNumber { get; } = "4312";
        public float Amount { get; } = 90.23f;
        public string Address { get; } = "house 100, vaikunth";

        //item ids that user has requested
        public string[] Itemids { get; } = { "123", "232", "321", "234" };
    }
}