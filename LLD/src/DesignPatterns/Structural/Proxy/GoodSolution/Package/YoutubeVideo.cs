namespace src.DesignPatterns.Structural.Proxy.Package.GoodSolution
{
    public class YoutubeVideo : IVideo
    {

        private string _videoid;
        //passing videoid we need to fetch from this package API
        public YoutubeVideo(string videoId)
        {
            _videoid = videoId;
            Download();
        }

        private void Download()
        {
            System.Console.WriteLine("Downloading video with id " + _videoid + "from youtube API");
        }

        public string GetVideoId()
        {
            return _videoid;
        }

        public void Render()
        {
            System.Console.WriteLine("Getting video"+_videoid+" now");
        }
    }
}