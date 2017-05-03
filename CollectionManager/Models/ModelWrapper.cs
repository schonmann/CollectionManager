using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CollectionManager.Models
{
    public class ModelWrapper
    {
        [JsonProperty("item")]
        public Item Item { get; set; }

        [JsonProperty("loan")]
        public Loan Loan { get; set; }

        [JsonProperty("person")]
        public Person Person { get; set; }

        [JsonProperty("place")]
        public Place Place { get; set; }

        [JsonProperty("date")]
        public DateTime Date { get; set; }
    }
}