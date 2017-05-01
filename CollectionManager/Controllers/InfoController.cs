using CollectionManager.DAO;
using CollectionManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CollectionManager.Controllers
{
    [RoutePrefix("api/info")]
    public class InfoController : ApiController
    {
        [HttpGet]
        [Route("types/all")]
        public string[] GetTypesPt()
        {
            return new InfoElasticServerDAO().GetTypes();
        }
    }
}
