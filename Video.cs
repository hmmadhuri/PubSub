using System;
using System.Collections.Generic;
using System.Text;

namespace PubSubConsoleApp_YouTube
{
    class Video
    {
        public string Title { get; set; }
        public DateTime Time { get; set; }
        public YouTubeUser Creator { get; set; }
    }
}
