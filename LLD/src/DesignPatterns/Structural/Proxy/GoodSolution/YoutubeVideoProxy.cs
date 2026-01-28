using src.DesignPatterns.Structural.Proxy.Package.GoodSolution;

namespace src.DesignPatterns.Structural.Proxy.GoodSolution
{
    public class YoutubeVideoProxy : IVideo
    {
        private string _videoId;

        private YoutubeVideo _youtubeVideo;

        public YoutubeVideoProxy(string videoid)
        {
            _videoId = videoid;
        }
        public string GetVideoId()
        {
            return _videoId;
        }

        public void Render()
        {
            if (_youtubeVideo == null)
            {
                //only create/download when this method is called
                _youtubeVideo = new YoutubeVideo(_videoId);
                _youtubeVideo.Render();
            }
        }
    }
}