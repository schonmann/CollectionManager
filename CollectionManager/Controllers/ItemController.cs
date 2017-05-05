using CollectionManager.DAO;
using CollectionManager.Models;
using System.Web.Http;
using Nest;
using CollectionManager.Database;
using System.Net.Http;
using System;
using System.Net;

namespace CollectionManager.Controllers
{
    [RoutePrefix("api/item")]
    public class ItemController : ApiController
    {
        [HttpGet]
        [Route("all")]
        public HttpResponseMessage GetAll()
        {
            try {
                Item[] items = new ItemElasticServerDAO().GetAll();
                return Request.CreateResponse(HttpStatusCode.OK, items);
            }catch(Exception e) {
                HttpError err = new HttpError(e.Message);
                return Request.CreateResponse(HttpStatusCode.InternalServerError, err);
            }
        }

        [HttpGet]
        [Route("byId/{id}")]
        public Item GetById(string id)
        {
            return new ItemElasticServerDAO().GetById(id);
        }

        [HttpPost]
        [Route("insert")]
        public void InsertItem([FromBody] Item item)
        {
            new ItemElasticServerDAO().InsertItem(item);
        }

        [HttpPost]
        [Route("update")]
        public void UpdateItem([FromBody] Item item)
        {
            new ItemElasticServerDAO().UpdateItem(item);
        }

        [HttpPost]
        [Route("delete")]
        public void DeleteTitle([FromBody]Item item)
        {
            new ItemElasticServerDAO().DeleteItem(item);
        }
    }
}
