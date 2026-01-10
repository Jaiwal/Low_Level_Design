namespace src.SOLID.I
{
    public class Circle : Ishape2D
    {
        public double Radius { get; set; }
        public double Area()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        // public double Volume()
        // {
        //     //here you're being forced to implement something which you dont need, should not be here
        //     throw new InvalidOperationException("This is not applicable for 2d shape");
        // }
        
        //can remove the method since we now implementing 2d
    }
}