using Nest;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CollectionManager.Models
{
    [ElasticsearchType(Name = "place", IdProperty = "Id")]
    public class Place
    {
        public const string DEFAULT_INDEX = "places";

        [Text]
        [JsonProperty("id")]
        public string Id { get; set; }

        [Text]
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}