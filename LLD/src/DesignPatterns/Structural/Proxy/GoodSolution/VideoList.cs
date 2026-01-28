
using src.DesignPatterns.Structural.Proxy.Package.GoodSolution;

namespace src.DesignPatterns.Structural.Proxy.GoodSolution
{
    public class VideoList
    {
        //the user of the pacakge, from where we will use API

        private Dictionary<string, IVideo> _videoList = new Dictionary<string, IVideo>();

        public void Add(IVideo video)
        {
            _videoList.Add(video.GetVideoId(), video);
        }

        public void Watch(string videoid)
        {
            var video = _videoList[videoid];
            video.Render();
        }
  }
}