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
    [RoutePrefix("api/person")]
    public class PersonController : ApiController
    {
        [HttpPost]
        [Route("insert")]
        public void InsertPerson([FromBody] Person person)
        {
            new PersonElasticServerDAO().InsertPerson(person);
        }

        [HttpGet]
        [Route("all")]
        public Person[] GetAllPeople()
        {
            return new PersonElasticServerDAO().GetAllPerson();
        }

        [HttpPost]
        [Route("update")]
        public void UpdatePerson([FromBody] Person person)
        {
            new PersonElasticServerDAO().UpdatePerson(person);
        }

        [HttpPost]
        [Route("delete")]
        public void DeletePerson([FromBody] Person person)
        {
            new PersonElasticServerDAO().DeletePerson(person);
        }
    }
}
