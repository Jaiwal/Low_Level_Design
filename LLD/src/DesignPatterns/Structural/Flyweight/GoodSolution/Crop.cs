namespace src.DesignPatterns.Structural.Flyweight.GoodSolution
{
    public class Crop
    {
        private int _x; // 4 bytes
        private int _y; //4 bytes

        private CropIcon _cropIcon;

        public Crop(int x, int y, CropIcon cropIcon)
        {
            _x = x;
            _y = y;
            _cropIcon = cropIcon;
        }

        public void Render()
        {
            System.Console.WriteLine($"Drwaing {_cropIcon.GetType()} at ({_x},{_y})");
        }
    }
}