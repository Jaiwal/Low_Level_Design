/*
public class Shape
{
    public ShapeType Type { get; set; }

    public double Radius { get; set; }

    public double Length { get; set; }

    public double width { get; set; }

    public double CalculateArea()
    {
        switch (Type)
        {
            case ShapeType.Cirlcle:
                return Math.PI * Math.Pow(Radius, 2);
            case ShapeType.Rectangle:
                return Length * width;
            default:
                throw new InvalidOperationException("Unsupported shape type")
    ;
        }
    }
}
*/
//this right here violates "O" since everytime we would add a shape, it would require modifying this class
//to add more fields required to calculate area and also method would change

//refactor like below instead and whenever you add new shape, you provide your own implementation of area
namespace src.SOLID.O
{
public abstract class Shape
{
    public abstract double CalculateArea();


}
}
