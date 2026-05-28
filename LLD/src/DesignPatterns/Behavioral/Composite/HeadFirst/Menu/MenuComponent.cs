namespace src.DesignPatterns.Behavioral.Composite.HeadFirst.Menu
{
    //component
    public abstract class MenuComponent
    {
        public virtual string Name => throw new NotImplementedException();
        public virtual string Description => throw new NotImplementedException();
        public virtual decimal Price => throw new NotImplementedException();
        public virtual bool IsVegeterian => throw new NotImplementedException();

        public virtual void Add(MenuComponent menuComponent)
        {
            throw new NotImplementedException();
        }

        public virtual void Remove(MenuComponent menuComponent)
        {
            throw new NotImplementedException();
        }

        public virtual MenuComponent GetChild(int i)
        {
            throw new NotImplementedException();
        }

        public virtual void Print()
        {
            throw new NotImplementedException();
        }
        
    }
}