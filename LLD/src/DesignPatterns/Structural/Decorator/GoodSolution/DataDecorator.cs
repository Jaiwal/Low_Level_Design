namespace src.DesignPatterns.Structural.Decorator.GoodSolution
{   
    //this sort of like preparation class for all sort of decorators
    public abstract class DataDecorator : IData

    {
        //reference to the object it will decorate, making protected so classes inherting can have this field to them
        protected IData _data;

        public DataDecorator(IData data)
        {
            _data = data;
        }
        //so that classes extended can have their own defination
        public abstract void Save(string data);

    }
}