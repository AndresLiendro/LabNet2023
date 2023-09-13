using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace labNetPractica6.MVC.Models
{
    public class CharacterResponse
    {
        public CharacterApiInfo info { get; set; }
        public List<CharacterView> results { get; set; }
    }

    public class CharacterApiInfo
    {
        public int count { get; set; }
        public int pages { get; set; }
        public string next { get; set; }
        public string prev { get; set; }
    }
}