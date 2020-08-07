namespace WebApplication2.Data.Models
{
    public class debils
    {
        public int id { get; set; }
        public string img { get; set; }
        public string name { get; set; }
        public string desc { get; set; }
        public bool isCockold { get; set; }
        public debilscats cat { get; set; }
    }
}
