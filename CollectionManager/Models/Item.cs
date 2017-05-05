using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Nest;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace CollectionManager.Models
{
    [ElasticsearchType(Name = "item", IdProperty = "Id")]
    public class Item
    {
        public const string ELASTIC_INDEX = "items";

        [Text]
        [JsonProperty("id")]
        public string Id { get; set; }

        [Text]
        [JsonProperty("name")]
        public string Name { get; set; }

        [Text]
        [JsonProperty("description")]
        public string Description { get; set; }
        
        [Nested]
        [JsonProperty("data_sheet")]
        public Dictionary<String, String> DataSheet {get;set;}
        
        [Text]
        [JsonProperty("place_id")]
        public string Place_Id { get; set; }
         
        [Text]
        [JsonProperty("type")]
        public ItemType Type { get; set; }

        [Text]
        [JsonProperty("img")]
        public string Img { get; set; }
    }
}