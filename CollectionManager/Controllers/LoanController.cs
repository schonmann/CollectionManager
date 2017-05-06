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
    [RoutePrefix("api/loan")]
    public class LoanController : ApiController
    {
        [HttpPost]
        [Route("start")]
        public void StartLoan([FromBody]ModelWrapper wrapper)
        {
            new LoanElasticServerDAO().StartLoan(wrapper.Item, wrapper.Person, wrapper.Date);
        }

        [HttpPost]
        [Route("end")]
        public void EndLoan([FromBody]ModelWrapper wrapper)
        {
            new LoanElasticServerDAO().EndLoan(wrapper.Item, wrapper.Person, wrapper.Date);
        }

        [HttpGet]
        [Route("byItem/{itemId}")]
        public Loan[] GetByItem(string itemId)
        {
            return new LoanElasticServerDAO().GetByItem(itemId);
        }

        [HttpGet]
        [Route("byPerson/{personId}")]
        public Loan[] GetByPerson(string personId)
        {
            return new LoanElasticServerDAO().GetByPerson(personId);
        }

        [HttpGet]
        [Route("all")]
        public Loan[] GetAll()
        {
            return new LoanElasticServerDAO().GetAll();
        }
    }
}
