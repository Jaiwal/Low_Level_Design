namespace src.DesignPatterns.Structural.Decorator.GoodSolution
{
    public class CloudData : IData
    {
        private string _url;

        public CloudData(string url)
        {
            _url = url; //url is the location where we want to store the data in cloud
        }
        public void Save(string data)
        {
            System.Console.WriteLine($"saving {data} to cloud at location {_url}");
        }
    }
}