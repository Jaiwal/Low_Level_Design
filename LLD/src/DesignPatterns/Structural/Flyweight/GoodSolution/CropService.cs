namespace src.DesignPatterns.Structural.Flyweight.GoodSolution
{
    public class CropService
    {

        //storing reference to the factory
        private CropIconFactory _iconFactory;

        public CropService(CropIconFactory cropIconFactory)
        {
            _iconFactory = cropIconFactory;
        }


        public List<Crop> GetCrops()
        {
            List<Crop> cropList = new List<Crop>();

            //fetching from fb(simulating below)

            var carrot1 = new Crop(1, 1, _iconFactory.GetCropIcon(CropType.Carrot));
            var carrot2 = new Crop(12, 2, _iconFactory.GetCropIcon(CropType.Carrot));
            var carrot3 = new Crop(2, 11, _iconFactory.GetCropIcon(CropType.Carrot));

            cropList.Add(carrot1);
            cropList.Add(carrot2);
            cropList.Add(carrot3);

            return cropList;
        }
    }
}