using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CollectionManager.Models
{
    public class Filter
    {
        [JsonProperty("field")]
        public string Field { get; set; }
        [JsonProperty("type")]
        public int Type { get; set; }
        [JsonProperty("is_loaned")]
        public bool IsLoaned { get; set; }
        [JsonProperty("query")]
        public string Query { get; set; }
    }
}