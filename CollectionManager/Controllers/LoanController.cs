using CollectionManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CollectionManager.Controllers
{
    [RoutePrefix("api/loan")]
    public class LoanController : ApiController
    {
        [HttpPost]
        [Route("start")]
        public void StartLoan()
        {

        }

        [HttpPost]
        [Route("stop")]
        public void StopLoan()
        {

        }
    }
}
