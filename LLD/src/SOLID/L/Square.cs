// namespace src.SOLID.L
// {
//     public class Square : Rectangle
//     {
//         public override double Width
//         {
//             get => base.Width;
//             set => base.Width = base.Height = value;
//         }

//         public override double Height
//         {
//             get => base.Height;
//             set => base.Height = base.Width = value;
//         }
//     }
// /*Without this override, 
// the Square class would allow Width and Height to be set independently, 
// which would violate the definition of a square.*/
// }


namespace src.SOLID.L
{
    public class Square : Shape
    {
        public double SideLength{ get; set; }

        public override double Area => SideLength*SideLength;
    }

}