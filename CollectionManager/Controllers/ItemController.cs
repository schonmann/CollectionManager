using CollectionManager.DAO;
using CollectionManager.Models;
using System.Web.Http;
using Nest;
using CollectionManager.Database;

namespace CollectionManager.Controllers
{
    [RoutePrefix("api/item")]
    public class ItemController : ApiController
    {
        [HttpGet]
        [Route("all")]
        public Item[] GetAll()
        {
            return new ItemElasticServerDAO().GetAll();
        }

        [HttpGet]
        [Route("byPattern/{pattern}")]
        public Item[] GetByPattern(string pattern)
        {
            return new ItemElasticServerDAO().GetByPattern(pattern);
        }

        [HttpGet]
        [Route("byId/{id}")]
        public Item GetById(long id)
        {
            return new ItemElasticServerDAO().GetById(id);
        }

        [HttpGet]
        [Route("byType/{type}")]
        public Item[] GetByType(string type)
        {
            return new ItemElasticServerDAO().GetByType(type);
        }

        [HttpPost]
        [Route("insert")]
        public void InsertTitle([FromBody] Item title)
        {
            new ItemElasticServerDAO().InsertTitle(title);
        }
    }
}
