using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace labNetPracica7.API.Models
{
    public class MortyView
    {
        public int id { get; set; }
        public string name { get; set; }
        public string status { get; set; }
        public string species { get; set; }
        public string type { get; set; }
        public string gender { get; set; }
        public MortyLocation origin { get; set; }
        public MortyLocation location { get; set; }
        public string image { get; set; }
        public List<string> episode { get; set; }
        public string url { get; set; }
        public DateTime created { get; set; }
    }

    public class MortyLocation
    {
            public string name { get; set; }
            public string url { get; set; }
    }
}