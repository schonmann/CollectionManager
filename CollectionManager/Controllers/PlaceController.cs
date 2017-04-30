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
    [RoutePrefix("api/place")]
    public class PlaceController : ApiController
    {
        [HttpPost]
        [Route("insert")]
        public void InsertPlace([FromBody] Place place)
        {
            new PlaceElasticServerDAO().InsertPlace(place);
        }

        [HttpGet]
        [Route("all")]
        public Place[] GetAllPlaces()
        {
            return new PlaceElasticServerDAO().GetAllPlaces();
        }
    }
}
