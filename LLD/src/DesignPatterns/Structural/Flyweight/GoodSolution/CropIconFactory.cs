namespace src.DesignPatterns.Structural.Flyweight.GoodSolution
{
    public class CropIconFactory
    {
        //this dict is going to act as our cache
        private Dictionary<CropType, CropIcon> _icons = new Dictionary<CropType, CropIcon>();


        public CropIcon GetCropIcon(CropType cropType)
        {
            if (!_icons.ContainsKey(cropType))
            {
                //does not exist yet
                var icon = new CropIcon(cropType, null);
                _icons.Add(cropType, icon);

            }

            return _icons[cropType];
        }
    }
}