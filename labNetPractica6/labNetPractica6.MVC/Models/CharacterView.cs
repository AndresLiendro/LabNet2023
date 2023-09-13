using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace labNetPractica6.MVC.Models
{
    public class CharacterView
    {
        public int id { get; set; }
        public string name { get; set; }
        public string status { get; set; }
        public string species { get; set; }
        public string type { get; set; }
        public string gender { get; set; }
        public CharacterLocation origin { get; set; }
        public CharacterLocation location { get; set; }
        public string image { get; set; }
        public List<string> episode { get; set; }
        public string url { get; set; }
        public DateTime created { get; set; }
    }

    public class CharacterLocation
    {
        public string name { get; set; }
        public string url { get; set; }
    }
}