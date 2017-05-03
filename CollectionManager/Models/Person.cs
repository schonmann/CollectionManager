using Nest;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CollectionManager.Models
{
    [ElasticsearchType(Name = "person", IdProperty = "Id")]
    public class Person
    {
        public const string ELASTIC_INDEX = "people";

        [Text]
        [JsonProperty("id")]
        public string Id { get; set; }

        [Text]
        [JsonProperty("name")]
        public string Name { get; set; }

        [Text]
        [JsonProperty("email")]
        public string Email { get; set; }

        [Text]
        [JsonProperty("phone")]
        public string Phone { get; set; }
    }
}