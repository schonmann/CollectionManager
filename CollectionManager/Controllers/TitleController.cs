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
        const string baseURL = "api/cd";

        // Get all CD's.
        [Route(baseURL + "/all")]
        public Title[] Get()
        {
            return new TitleDAO().GetAll();
        }

        // Get CD's by pattern.
        [Route(baseURL + "/byPattern/{pattern}")]
        public Title[] Get(string pattern)
        {
            return new TitleDAO().GetByPattern(pattern);
        }

        // Get CD by id.
        [Route(baseURL + "/byId/{id}")]
        public Title Get(long id)
        {
            return new TitleDAO().GetById(id);
        }

        [Route(baseURL + "byType/{type}")]
        public Title[] Get(string type)
        {
            return new TitleDAO().GetById(id);
        }
    }
}
