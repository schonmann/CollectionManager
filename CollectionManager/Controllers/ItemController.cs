﻿using CollectionManager.DAO;
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
        [Route("byId/{id}")]
        public Item GetById(string id)
        {
            return new ItemElasticServerDAO().GetById(id);
        }

        [HttpPost]
        [Route("insert")]
        public void InsertTitle([FromBody] Item item)
        {
            new ItemElasticServerDAO().InsertTitle(item);
        }

        [HttpPost]
        [Route("delete")]
        public void DeleteTitle([FromBody]Item item)
        {
            new ItemElasticServerDAO().DeleteTitle(item);
        }
    }
}
