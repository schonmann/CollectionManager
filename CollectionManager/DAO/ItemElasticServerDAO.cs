using CollectionManager.Models;
using CollectionManager.Database;
using Nest;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Collections.ObjectModel;
using System;

namespace CollectionManager.DAO
{
    public class ItemElasticServerDAO : ItemDAO
    {    

        public Item GetById(long Id) 
        {
            var elastic = ElasticServer.GetClient();
            return null;
        }
        
        //Returns all title registers.
        public Item[] GetAll()
        {
            var results = new List<Item>();
            var elastic = ElasticServer.GetClient();
            var result = elastic.Search<Item>(s => s.From(0).Size(2000).AllTypes().Scroll("5m"));
            if(result.ServerError != null) throw new System.Exception(result.ServerError.Error.ToString());
            return new List<Item>(result.Documents).ToArray();
        }

        //Returns all by name pattern.
        public Item[] GetByPattern(string pattern)
        {
            return null;
        }

        //Returns all by title type.
        public Item[] GetByType(string type)
        {
            return null;
        }

        //Insert title to database.
        public void InsertTitle(Item t)
        {
            var elastic = ElasticServer.GetClient();
            var titleType = t.Type.ToString().ToLower();
            var result = elastic.Index(t, m => m.Type(titleType));
            if(result.ServerError != null) throw new System.Exception(result.ServerError.Error.ToString());
        }

        //Update title in the database.
        public void UpdateTitle(Item t)
        {

        }

        public void Delete(Item item)
        {
            var elastic = ElasticServer.GetClient();
            var titleType = item.Type.ToString().ToLower();
            var result = elastic.Delete<Item>(item, t=>t.Type(titleType));
            if (result.ServerError != null) throw new System.Exception(result.ServerError.Error.ToString());
        }
    }
}