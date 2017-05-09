using System;

namespace WarframeNET
{
    public class NewsArticle
    {
        public string Id { get; set; }

        public string Message { get; set; }

        public string Link { get; set; }

        public bool Priority { get; set; }

        public DateTime Date { get; set; }

        public string ImageLink { get; set; }

        internal NewsArticle() { }
    }
}