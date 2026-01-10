namespace src.SOLID.O
{
  public class Cirlcle : Shape
{
    public double Radius { get; set; }
    public override double CalculateArea()
    {
        return Math.PI * Math.Pow(Radius, 2);
    }
}  
}
