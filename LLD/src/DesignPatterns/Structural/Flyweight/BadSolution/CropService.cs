namespace src.DesignPatterns.Structural.Flyweight.BadSolution
{
    public class CropService
    {
        public List<Crop> GetCrops()
        {
            List<Crop> cropList = new List<Crop>();

            //fetching from fb(simulating below)

            var carrot1 = new Crop(1, 1, CropType.Carrot, null);
            var carrot2 = new Crop(12, 2, CropType.Carrot, null);
            var carrot3 = new Crop(2, 11, CropType.Carrot, null);

            cropList.Add(carrot1);
            cropList.Add(carrot2);
            cropList.Add(carrot3);

            return cropList;
        }
    }
}