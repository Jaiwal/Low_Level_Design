namespace src.DesignPatterns.Structural.Flyweight.BadSolution
{
    public class Crop
    {
        private int _x; // 4 bytes
        private int _y; //4 bytes

        private CropType _cropType; //4 bytes

        private byte[] _icon; //40kb 

        public Crop(int x, int y, CropType cropType, byte[] icon)
        {
            _x = x;
            _y = y;
            _cropType = cropType;
            _icon = icon;
        }

        public void Render()
        {
            System.Console.WriteLine($"Drwaing {_cropType} at ({_x},{_y})");
        }
    }
}