using CollectionManager.DAO;
using CollectionManager.Models;
using System.Web.Http;

namespace CollectionManager.Controllers
{
    public class TitleController : ApiController
    {
        const string baseURL = "api/title";

        [HttpGet]
        [Route(baseURL + "/all")]
        public Title[] GetAll()
        {
            return new TitleElasticServerDAO().GetAll();
        }

        [HttpGet]
        [Route(baseURL + "/byPattern/{pattern}")]
        public Title[] GetByPattern(string pattern)
        {
            return new TitleElasticServerDAO().GetByPattern(pattern);
        }

        [HttpGet]
        [Route(baseURL + "/byId/{id}")]
        public Title GetById(long id)
        {
            return new TitleElasticServerDAO().GetById(id);
        }

        [HttpGet]
        [Route(baseURL + "/byType/{type}")]
        public Title[] GetByType(string type)
        {
            return new TitleElasticServerDAO().GetByType(type);
        }

        [HttpPost]
        [Route(baseURL + "/insert")]
        public void InsertTitle([FromBody] Title title)
        {
            new TitleElasticServerDAO().InsertTitle(title);
        }
    }
}
