using System;
using System.Collections.Generic;

namespace WarframeNET
{
    public class News
    {
        public List<NewsArticle> Articles { get; set; }

        internal News() { }
    }

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