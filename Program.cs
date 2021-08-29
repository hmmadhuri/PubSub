using System;

namespace PubSubConsoleApp_YouTube
{
    class Program
    {
        static void Main(string[] args)
        {
            YouTubeUser GeeksForGeeks = new YouTubeUser("GeeksForGeeks");
            YouTubeUser LeetCode = new YouTubeUser("LeetCode");
            YouTubeUser Student = new YouTubeUser("Student");
            YouTubeUser KDrama = new YouTubeUser("KDrama");

            var algorithms = new Video { Title = "Algorithms", Time = DateTime.Now, Creator=GeeksForGeeks};
            var ds = new Video { Title = "DataStructures", Time = DateTime.Now, Creator=LeetCode };
            var drama = new Video { Title = "KDrama", Time = DateTime.Now, Creator = KDrama };

            Student.Subscribe(GeeksForGeeks);
            Student.Subscribe(LeetCode);
            Student.Subscribe(KDrama);

            GeeksForGeeks.UploadVideo(algorithms);
            LeetCode.UploadVideo(ds);
            KDrama.UploadVideo(drama);

            var placement = new Video { Title = "PlacementSeries", Time = DateTime.Now, Creator = GeeksForGeeks };
            GeeksForGeeks.UploadVideo(placement);

            Student.UnSubscribe(KDrama);

            drama = new Video { Title = "New KDrama", Time = DateTime.Now, Creator = KDrama };
            KDrama.UploadVideo(drama);

        }
    }
}
