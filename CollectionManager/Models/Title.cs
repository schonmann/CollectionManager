using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CollectionManager.Models
{
    public enum TitleType
    {
        Book,
        Cd,
        Dvd
    }

    public class Title
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public Dictionary<String, String> DataSheet {get;set;}
        public Place Place { get; set; }
    }
}