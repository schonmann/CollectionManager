using Nest;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CollectionManager.Models
{
    [ElasticsearchType(Name = "loan", IdProperty = "Id")]
    public class Loan
    {
        public const string ELASTIC_INDEX = "loan";

        [Text]
        [JsonProperty("id")]
        public string Id { get; set; }

        [Text]
        [JsonProperty("person_id")]
        public string PersonId { get; set; }

        [Text]
        [JsonProperty("item_id")]
        public string ItemId { get; set; }

        [Date]
        [JsonProperty("start_date")]
        public DateTime StartDate { get; set; }

        [Date]
        [JsonProperty("end_date")]
        public DateTime EndDate { get; set; }
    }
}