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
        public const string DEFAULT_INDEX = "items";

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
        
        [Nested]
        [JsonProperty("place_id")]
        public long PlaceId { get; set; }
         
        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty("type")]
        public ItemType Type { get; set; }
    }
}