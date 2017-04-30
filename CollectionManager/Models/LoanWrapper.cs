using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CollectionManager.Models
{
    public class LoanWrapper
    {
        [JsonProperty("loan")]
        public Loan Loan {get; set;}
        [JsonProperty("person")]
        public Person Person { get; set; }
    }
}