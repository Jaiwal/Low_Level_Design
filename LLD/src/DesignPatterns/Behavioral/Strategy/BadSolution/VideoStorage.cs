namespace src.DesignPatterns.Behavioral.Strategy.BadSolution
{
    public class VideoStorage
    {
        private Compressors _compressor;

        private Overlays _overlay;

        public VideoStorage(Compressors compressor, Overlays overlay = Overlays.None)
        {
            _compressor = compressor;
            _overlay = overlay;
        }

        public void SetCompressor(Compressors compressor)
        {
            _compressor = compressor;
        }

        public void SetOverlay(Overlays overlay)
        {
            _overlay = overlay;
        }

        public void Store(string fileName)
        {
            if (_compressor == Compressors.MOV)
            {
                System.Console.WriteLine("compressing using MOV");
            }
            else if (_compressor == Compressors.MP4)
            {
                System.Console.WriteLine("compressing using MP4");
            }
            else if (_compressor == Compressors.WEBM)
            {
                System.Console.WriteLine("compressing using WEBM");
            }

            //logic for applying overlays

            if (_overlay == Overlays.BlackAndWhite)
            {
                System.Console.WriteLine("Applying black and white");
            }
            else if (_overlay == Overlays.Blue)
            {
                System.Console.WriteLine("Applying Blue");
            }
            else if (_overlay == Overlays.None)
            {
                System.Console.WriteLine("Applying nothing");
            }

            System.Console.WriteLine("Storing video to " + fileName +"."+ _compressor);
        }

       
    }
}