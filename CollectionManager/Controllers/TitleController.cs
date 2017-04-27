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
    public class TitleController : ApiController
    {
        const string baseURL = "api/title";

        [HttpGet]
        [Route(baseURL + "/all")]
        public Title[] GetAll()
        {
            return new TitleDAO().GetAll();
        }

        [HttpGet]
        [Route(baseURL + "/byPattern/{pattern}")]
        public Title[] GetByPattern(string pattern)
        {
            return new TitleDAO().GetByPattern(pattern);
        }

        [HttpGet]
        [Route(baseURL + "/byId/{id}")]
        public Title GetById(long id)
        {
            return new TitleDAO().GetById(id);
        }

        [HttpGet]
        [Route(baseURL + "/byType/{type}")]
        public Title[] GetByType(string type)
        {
            return new TitleDAO().GetByType(type);
        }
    }
}
