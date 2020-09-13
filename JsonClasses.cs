using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorTube
{
    public class JsonClasses
    {
        public class Subtitle
        {
            public string name { get; set; } //Channel Name
            public string url { get; set; }
        }

        public class Entry_Data
        {
            public string header { get; set; }
            public string title { get; set; }
            public string titleUrl { get; set; }
            public List<Subtitle> subtitles { get; set; }
            public DateTime time { get; set; }
            public List<string> products { get; set; }
        }
    }

    public class ContentRating
    {
    }

    public class ContentDetails
    {
        public string duration { get; set; }
        public string dimension { get; set; }
        public string definition { get; set; }
        public string caption { get; set; }
        public bool licensedContent { get; set; }
        public ContentRating contentRating { get; set; }
        public string projection { get; set; }
    }

    public class Item
    {
        public string kind { get; set; }
        public string etag { get; set; }
        public string id { get; set; }
        public ContentDetails contentDetails { get; set; }
    }

    public class PageInfo
    {
        public int totalResults { get; set; }
        public int resultsPerPage { get; set; }
    }

    public class VideoDetailsRoot
    {
        public string kind { get; set; }
        public string etag { get; set; }
        public List<Item> items { get; set; }
        public PageInfo pageInfo { get; set; }
    }




}
