// namespace src.SOLID.I
// {
//     public interface Ishape
//     {
//         double Area();

//         //this below is enforcing to implement such methods which we might not need
//         double Volume();
//     }
// }


//instead create segregated interface
namespace src.SOLID.I
{
    public interface Ishape3D
    {
        double Area();
        double Volume();
    }
}