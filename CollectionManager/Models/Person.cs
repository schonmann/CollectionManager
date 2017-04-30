using Nest;
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

        [Text(Name = "id")]
        public string Id { get; set; }

        [Text(Name = "name")]
        public string Name { get; set; }

        [Text(Name = "email")]
        public string Email { get; set; }

        [Text(Name = "phone")]
        public string Phone { get; set; }
    }
}