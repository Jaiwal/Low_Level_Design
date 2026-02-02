



namespace src.DesignPatterns.Creational.Prototype.BadSolution
{
    public class ShapeActions
    {
        public void Duplicate(IShape shape)
        {
            if (shape is Circle)
            {
                var copiedshape = (Circle)shape;//copied shape
                var newshape = new Circle(); //the clone
                newshape.Radius = copiedshape.Radius;
                newshape.Draw();
            }
            else if (shape is Rectangle)
            {
                var copiedshape = (Rectangle)shape;
                var newshape = new Rectangle(); //clone
                newshape.Width = copiedshape.Width;
                newshape.Height = copiedshape.Height;
                newshape.Draw();
            }
            else
            {
                throw new ArgumentException("Invalid shape provided");
            }
        }
    }
}