namespace src.DesignPatterns.Structural.Decorator.BadSolution
{
    public class CloudData
    {
        //protected so classes that inherit have access, private wont be accssebile 
        protected string _url;

        public CloudData(string url)
        {
            _url = url; //url is the location where we want to store the data in cloud
        }

        public virtual void Save(string data)
        {
            System.Console.WriteLine($"saving {data} to cloud at location {_url}");
        }
  }
}