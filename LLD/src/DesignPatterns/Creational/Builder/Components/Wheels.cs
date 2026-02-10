namespace src.DesignPatterns.Creational.Builder.Components
{
    public class Wheels
    {
        private float _diameterinInches;

        public Wheels(float diameter)
        {
            _diameterinInches = diameter;
        }

        public float GetDiamterInInches()
        {
            return _diameterinInches;
        }
    }
}