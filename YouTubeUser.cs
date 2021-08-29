using System;
using System.Collections.Generic;
using System.Text;

namespace PubSubConsoleApp_YouTube
{
    class YouTubeUser
    {
        public string Name { get; set; }
        public YouTubeUser(string name)
        {
            this.Name = name;
        }

        private event EventHandler<Video> videoEventHandler;

        public void UploadVideo(Video video)
        {
            videoEventHandler?.Invoke(this,video);
        }

        public void Subscribe(YouTubeUser user)
        {
            user.videoEventHandler += Notify;
        }
        public void UnSubscribe(YouTubeUser user)
        {
            user.videoEventHandler -= Notify;
        }
        public void Notify(object sender, Video video)
        {
            var user = (YouTubeUser)sender;
            Console.WriteLine("YouTube user: " + video.Creator.Name + " uploaded a new video " + video.Title + " You are one of the people to be notified because you have subscribed to the user");
        }

    }
}
