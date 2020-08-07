using System.Collections.Generic;

namespace WebApplication2.Data.Models
{
    public class person
    {
        public int id { get; set; }
        public string img { get; set; }
        public string name { get; set; }
        public string desc { get; set; }
        public Info cats { get; set; }
    }
    public class Info
    {
        public bool dota { get; set; }
        public bool cs { get; set; }
        public bool osu { get; set; }
        public bool overwatch { get; set; }
        public bool paladins { get; set; }
        public bool apex { get; set; }
        public string catString{get;set;}
    }
}
