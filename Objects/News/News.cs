using System;
using System.Collections.Generic;

namespace WarframeNET
{
    public class News
    {
        public List<Article> Articles { get; set; }
    }

    public class Article
    {
        public string Id { get; set; }

        public string Message { get; set; }

        public string Link { get; set; }

        public bool Priority { get; set; }

        public DateTime Date { get; set; }

        public string ImageLink { get; set; }
    }
}