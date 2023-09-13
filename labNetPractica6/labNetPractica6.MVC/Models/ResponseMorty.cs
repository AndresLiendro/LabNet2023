using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace labNetPracica7.API.Models
{
    public class ResponseMorty
    {
        public MortyApiInfo info { get; set; }
        public List<MortyView> results { get; set; }
    }

    public class MortyApiInfo
    {
        public int count { get; set; }
        public int pages { get; set; }
        public string next { get; set; }
        public string prev { get; set; }
    }
}